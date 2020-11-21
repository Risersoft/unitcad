Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFCompDefBOMModel
    Inherits clsFormDataModel
    Dim myTFCD As New clsTFCDModel(myContext)
    Dim myVueArea As clsViewModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("WT")
        myVueArea = Me.GetViewModel("AREA")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Me.ValueLists.Add("DataType", myTFCD.myTFCompDef.myTFCDPrm.dicDataType.ToVList)
        Me.AddLookupField("DataType", "DataType")
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sqlForm = "Select * from TFCompDefDetBOM where TFCompDefDetBOMID=" & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "TFCompDefID", oView, prepMode, prepIDX, strXML)


        For Each str1 As String In New String() {"wt", "area"}
            Dim mView As clsViewModel = Me.GridViews(str1)
            mView.MainGrid.MainConf("autorowht") = True
            mView.MainGrid.MainConf("showrownumber") = True
            mView.MainGrid.MainConf("HIDECOLS") = If(myUtils.IsInList(str1, "wt"), "isareaint", "heightformula")
            Dim Sql As String = "select TFCompDefCalcID,TFCompDefID,TFCompDefDetBomId, sortindex,CalcType,SumType,FactorFormula,LengthFormula,WidthFormula,IsAreaInt,HeightFormula,QtyFormula, Remarks from tfcompdefcalc where " & myUtils.CombineWhere(False, "tfcompdefid=" & myRow("tfcompdefid"), "tfcompdefdetbomid=" & frmIDX, "calctype='" & str1 & "'")
            mView.MainGrid.QuickConf(Sql, True, "1-1-1-1-1-1-1-1", True, "")
            mView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE =""tfcompdefcalc"" IDFIELD=""tfcompdefcalcid"" ><COL KEY=""TFCompDefID,TFCompDefDetBomId,sortindex,CalcType,IsAreaInt,SumType,FactorFormula,LengthFormula,WidthFormula,HeightFormula,QtyFormula,Remarks""/></BAND>", EnumEditType.acCommandOnly)

        Next


        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("DescripFormula")).Trim.Length = 0 Then Me.AddError("DescripFormula", "Select Description")

        Dim RowCount As Integer = myContext.SQL.ParamValue("@RowCount", Me.ClientParams)
        If myUtils.cStrTN(myRow("ItemNumFixed")).Trim.Length = 0 AndAlso RowCount > 0 Then Me.AddError("ItemNumFixed", "Item parameters require fixed item no.")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("TFCompDefDetBOMID")
                frmMode = EnumfrmMode.acEditM

                myView.MainGrid.SaveChanges(0, "calctype=wt,tfcompdefdetbomid=" & frmIDX & ",tfcompdefid=" & myRow("tfcompdefid"))
                myVueArea.MainGrid.SaveChanges(0, "calctype=area,tfcompdefdetbomid=" & frmIDX & ",tfcompdefid=" & myRow("tfcompdefid"))
                VSave = True
                myContext.Provider.dbConn.CommitTransaction()
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsModelCollec(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsCollecString(Of clsViewModel)
        Dim dic As New clsCollecString(Of clsViewModel)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "arrvuecomp", "arrvueassy", "replacecomp"
                    dic = myTFCD.GenerateArrVueCollec(vwState, SelectionKey, Params)
            End Select
        End If
        Return dic
    End Function
End Class
