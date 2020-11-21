Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFCompDefModel
    Inherits clsFormDataModel
    Dim mvStdFF, myVueEnt, mvShots, mvDTCols, myVueBOM, myVueAct, myVueVol As clsViewModel
    Dim PrmListmyView, PrmListmyVueGrp, PrmListmvGloParam, PrmListmvInheritParam As clsViewModel
    Dim myTFCD As New clsTFCDModel(myContext)
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Det")
        mvStdFF = Me.GetViewModel("StdFF")
        myVueEnt = Me.GetViewModel("Ent")
        mvShots = Me.GetViewModel("Shots")
        mvDTCols = Me.GetViewModel("DTCols")
        myVueBOM = Me.GetViewModel("BOM")
        myVueVol = Me.GetViewModel("VOL")
        myVueAct = Me.GetViewModel("Act")
        PrmListmyView = Me.GetViewModel("local")
        PrmListmyVueGrp = Me.GetViewModel("grp")
        PrmListmvGloParam = Me.GetViewModel("GloParam")
        PrmListmvInheritParam = Me.GetViewModel("InheritParam")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim vlist1 As New clsValueList
        vlist1.Add(0, "None")
        vlist1.Add(1, "Entity 2D")
        vlist1.Add(2, "General Block")
        vlist1.Add(3, "Custom Block")
        vlist1.Add(4, "Entity 3D")
        Me.ValueLists.Add("IntDesignCode", vlist1)
        Me.AddLookupField("IntDesignCode", "IntDesignCode")

        Dim Sql As String = myFuncsBase.CodeWordSQL("compdef", "type", "")
        Me.AddLookupField("CompType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "CompType").TableName)

        Dim vlist2 As New clsValueList
        vlist2.Add(0, "Local Overrides Parent")
        vlist2.Add(1, "Parent Overrides Local")
        vlist2.Add(2, "Local Parameters not required")
        Me.ValueLists.Add("ParamBehave", vlist2)
        Me.AddLookupField("ParamBehave", "ParamBehave")

        If Not myContext.App Is Nothing Then
            Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select distinct defgroup from tfcompdef where defgroup is not null order by defgroup").Tables(0)
            Me.ValueLists.Add("DefGroup", myContext.SQL.VListFromTable(dt1))
            Me.AddLookupField("DefGroup", "DefGroup")

            dt1 = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select distinct viewname from tfcompdef where viewname is not null order by viewname").Tables(0)
            Me.ValueLists.Add("ViewName", myContext.SQL.VListFromTable(dt1))
            Me.AddLookupField("ViewName", "ViewName")
        End If


        Me.ValueLists.Add("DataType", myTFCD.myTFCompDef.myTFCDPrm.dicDataType.ToVList)
        Me.AddLookupField("DataType", "DataType")
        Me.IgnorefRow = True 'called from frmTFCompDef2D, frmTFCompDef3D
    End Sub

    Public Overrides Function PrepForm(ByVal oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        Dim Sql As String = "select * from tfcompdef where tfcompdefid = " & myUtils.cValTN(prepIDX)
        Me.InitData(Sql, "dtbased,comptype", oView, prepMode, myUtils.cValTN(prepIDX), strXML, "tfcompdefid", "compdefcode")

        If myUtils.cValTN(Me.CopyIDX) > 0 Then
            Sql = "select sortindex,datatype,ParamCode,ParamName,Formula,ParamValue,CheckFormula from TFCompDefParam where tfcompdefid=" & Me.CopyIDX
            Me.AddDataSet("TFCompDefParam", Sql)
        End If

        myView.MainGrid.BindGridData(GenerateData("det", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "1-2-2-4", True)

        mvStdFF.MainGrid.BindGridData(GenerateData("stdff", frmIDX), 0)
        mvStdFF.MainGrid.QuickConf("", True, "1", True, "Standard Folders for this component")
        mvStdFF.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""tfcompdefstdffid"" TABLE=""tfcompdefstdff""><COL KEY=""tfcompdefid,foldername""/></BAND>", EnumEditType.acCommandOnly)


        myVueEnt.MainGrid.MainConf("FORMATXML") = "<COL KEY=""WorkFeat"" CAPTION=""Work"" VLIST=""False;No|True;Yes""/>"
        Sql = "select tfcompdefentid,tfcompdefid,WorkFeat,EntCode,EntName,Path1,Path2,Path3,Path4 from TFCompDefEnt where tfcompdefid=" & frmIDX
        myVueEnt.MainGrid.QuickConf(Sql, True, "1-1-1-1-1-1-1", True, "Entities")


        mvShots.MainGrid.BindGridData(GenerateData("shot", frmIDX), 0)
        mvShots.MainGrid.QuickConf("", True, "2-1-1-3-3", True)


        If myUtils.cValTN(Me.CopyIDX) > 0 Then
            Sql = "select * from TFCompDefDetBOM where isnull(isbom,0)=1 and tfcompdefid=" & Me.CopyIDX
            Me.AddDataSet("TFCompDefDetBOM", Sql)
        End If

        If myUtils.cValTN(myRow("dtbased")) = 1 Then
            myTFCD.SetupDTR(Me, Me.mvDTCols)
        Else
            myTFCD.SetupBOMView(myVueBOM, frmIDX)
            myTFCD.SetupCalcView(myVueVol, frmIDX, "", "VOL")
            myTFCD.SetupActPackView(myVueAct, frmIDX, myRow("CompType"))
        End If

        Dim oWO As clsWOInfoBase = myPIDU.GenerateWOInfo(myContext, myUtils.cValTN(Me.vBag("PIDUnitID")))
        myTFCD.InitForm(oWO, PrmListmvGloParam, PrmListmyView, PrmListmvInheritParam, "tfcompdefid", myUtils.cValTN(myRow("tfcompdefid")))
        If myUtils.cValTN(myRow("dtbased")) <> 1 Then myTFCD.SetupParamGrpView(PrmListmyVueGrp, frmIDX)

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()

        Dim oRet As clsProcOutput = myIntent.ValidateIdentifier(myUtils.cStrTN(myRow("CompDefCode")), True)
        If Not oRet.Success Then Me.AddError("CompDefCode", oRet.Message)
        If myUtils.cStrTN(myRow("Descrip")).Trim.Length = 0 Then Me.AddError("Descrip", "Enter Description")


        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False

        If Me.Validate Then
            If myUtils.cValTN(myRow("dtbased")) = 1 Then
                myRow("DTDispColKeys") = mvDTCols.MainGrid.SelColValueCSV("columnname", 0)
            ElseIf myUtils.IsInList(myRow("comptype"), "ASY") AndAlso myView.MainGrid.myDS.Tables(0).Select("isnull(inheritparams,0)=0 and isnull(inheritactpack,0)=0").Length > 0 Then
                If myUtils.cStrTN(myRow("compfilename")).Trim.Length > 0 Then
                    Dim extfile As String = System.IO.Path.GetExtension(myRow("compfilename"))
                    If myUtils.InStrList(extfile, "ipt") Then
                        myRow("Createnewasm") = True
                    End If
                End If
            End If

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("tfcompdefid")
                frmMode = EnumfrmMode.acEditM
                PrmListmyView.MainGrid.SaveChanges(, "tfcompdefid=" & frmIDX)
                PrmListmyVueGrp.MainGrid.SaveChanges(, "tfcompdefid=" & frmIDX)
                mvStdFF.MainGrid.SaveChanges(, "tfcompdefid=" & frmIDX)
                myVueVol.MainGrid.SaveChanges(, "CalcType=VOL,tfcompdefid=" & frmIDX)

                If myUtils.cValTN(myRow("dtbased")) <> 1 Then
                    myUtils.ChangeAll(myVueBOM.MainGrid.myDS.Tables(0).Select, "tfcompdefid=" & frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(myVueBOM.MainGrid.myDS.Tables(0), myTFCD.BindSQL("bom", "", frmIDX))

                    myUtils.ChangeAll(myVueEnt.MainGrid.myDS.Tables(0).Select, "tfcompdefid=" & frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(myVueEnt.MainGrid.myDS.Tables(0), myVueEnt.MainGrid.SQLGrid(frmIDX))
                    myContext.Provider.objSQLHelper.SaveResults(myView.MainGrid.myDS.Tables(0), "select tfcompdefdetbomid,sortindex from tfcompdefdetbom where tfcompdefdetbomid=0")
                End If

                myContext.Provider.dbConn.CommitTransaction()
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim myTFCD As New clsTFCDModel(myContext)
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "act"
                    Dim CompType As String = myUtils.cStrTN(myContext.SQL.ParamValue("@CompType", Params))
                    myTFCD.SetupActionViewConf(Model, CompType)
                    Dim Sql As String = myTFCD.SQLActPack(frmIDX, True)
                    Model.MainGrid.QuickConf(Sql, True, "1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1", True, "")
                Case "det"
                    Dim TfCompDefId As String = myUtils.cValTN(myContext.SQL.ParamValue("@TfCompDefId", Params))
                    Dim Sql As String = "select tfcompdefdetbomid, tfcompdef.tfcompdefid, CompDefCode, Descrip, Qtyformula, NewName, Remarks from tfcompdefdetbom inner join tfcompdef on tfcompdefdetbom.ChildCompDefID = tfcompdef.tfcompdefid  where isnull(isbom,0)=0 and tfcompdefdetbom.tfcompdefid= " & TfCompDefId
                    Model.MainGrid.QuickConf(Sql, True, "2-3-2-2-3", True)
            End Select
        End If
        Return Model
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "det"
                Dim Sql As String = "select tfcompdefdetbomid,inheritparams,inheritactpack,qtyformula,sortindex,tfcompdefid,ChildCompDefID,ChildCompDefID as DefID2,NewNameFormula, Remarks from TFCompDefDetBOM where isnull(isbom,0)=0 and tfcompdefid= " & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Case "shot"
                Dim Sql As String = "select tfcompdefshotid,tfcompdefid,ShotCode, ShotType, FileType, EvalCondition, Remark from tfcompdefshot where tfcompdefid= " & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Case "stdff"
                Dim Sql As String = "select tfcompdefstdffid, tfcompdefid, FolderName from TFCompDefStdFF where tfcompdefid=" & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
        End Select
        Return oRet.Data
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim myTFCD As New clsTFCDModel(myContext), Sql As String
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        Dim TfCompDefId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@TfCompDefId", Params))
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "act"
                    oRet.Data = myTFCD.BindDataTable("act", "", myUtils.cValTN(TfCompDefId))
                Case "deldet"
                    Dim SqlID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@SqlID", Params))
                    Sql = "delete from tfcompdefdetbom where tfcompdefdetbomid=" & SqlID
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
                    oRet.Data = GenerateData("det", TfCompDefId)
                Case "delbom"
                    Dim SqlID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@SqlID", Params))
                    Sql = "delete from tfcompdefdetbom where tfcompdefdetbomid=" & SqlID
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
                    oRet.Data = myTFCD.BindDataTable("bom", "", myUtils.cValTN(TfCompDefId))
                Case "delact"
                    Dim SqlID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@SqlID", Params))
                    Sql = "delete from tfcompdefactpack where tfcompdefactpackid=" & SqlID
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
                    oRet.Data = myTFCD.BindDataTable("act", "", myUtils.cValTN(TfCompDefId))
                Case "delshot"
                    Dim SqlID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@SqlID", Params))
                    Sql = "delete from tfcompdefshot where tfcompdefshotid=" & SqlID
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
                    oRet.Data = GenerateData("shot", TfCompDefId)
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim myTFCD As New clsTFCDModel(myContext)
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "det"
                oRet.Data = GenerateData("det", frmIDX)
            Case "bom"
                oRet.Data = myTFCD.BindDataTable("bom", "", myUtils.cValTN(frmIDX))
            Case "shot"
                oRet.Data = GenerateData("shot", frmIDX)
            Case "stdff"
                oRet.Data = GenerateData("stdff", frmIDX)
            Case "local"
                oRet.Data = myTFCD.BindDataTable("local", "tfcompdefid", myUtils.cValTN(frmIDX))
            Case "grp"
                oRet.Data = myTFCD.BindDataTable("grp", "", myUtils.cValTN(frmIDX))
            Case "deltabrows"
                Dim Sql As String = "delete from tfcompdefdetbom where tfcompdefdetbomid=" & myUtils.cValTN(frmIDX)
                myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModelCollec(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsCollecString(Of clsViewModel)
        Dim dic As New clsCollecString(Of clsViewModel)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "paramlist"
                    Dim TfCompDefId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@TfCompDefId", Params))
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PIDUnitID", Params))
                    Dim oWO As clsWOInfoBase = myPIDU.GenerateWOInfo(myContext, myUtils.cValTN(PIDUnitID))
                    Dim ModelGlo As New clsViewModel(vwState, myContext), ModelLoc As New clsViewModel(vwState, myContext), ModelInher As New clsViewModel(vwState, myContext)
                    myTFCD.InitForm(oWO, ModelGlo, ModelLoc, ModelInher, "tfcompdefid", myUtils.cValTN(TfCompDefId))

                    dic.AddUpd("gloparam", ModelGlo)
                    dic.AddUpd("local", ModelLoc)
                    dic.AddUpd("inheritparam", ModelInher)
                Case "makedtr"
                    Dim ModelDefDTR As New clsViewModel(vwState, myContext), ModelBlankDTR As New clsViewModel(vwState, myContext)
                    Dim DesTableCode As String = myUtils.cStrTN(myContext.SQL.ParamValue("@DesTableCode", Params))
                    Dim TfCompDefId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@TfCompDefId", Params))
                    Dim dsCompDef As DataSet = myIntent.LoadComponentDefData(myContext, True)
                    Dim ColumnNameCSV As String = myContext.SQL.PopulateSQLParams("@columnnamecsv", Params)
                    ColumnNameCSV = Replace(ColumnNameCSV, "'", "")
                    myTFCD.MakeDTR(TfCompDefId, DesTableCode, dsCompDef.Tables(0), ColumnNameCSV, ModelDefDTR, ModelBlankDTR)
                    dic.AddUpd("DefDTR", ModelDefDTR)
                    dic.AddUpd("BlankDTR", ModelBlankDTR)
                Case "arrvuecomp", "arrvueassy", "replacecomp"
                    dic = myTFCD.GenerateArrVueCollec(vwState, SelectionKey, Params)
            End Select
        End If
        Return dic
    End Function
End Class