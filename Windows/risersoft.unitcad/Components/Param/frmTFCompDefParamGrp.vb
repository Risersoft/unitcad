Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.UltraWinGrid

Public Class frmTFCompDefParamGrp
    Inherits frmMax

    Dim fp As frmTFCompDefBase, objCompDef As clsTFCompDefBase
    Dim EnableCheckBox As Boolean = False
    Public Sub InitForm()


        myView.SetGrid(Me.UltraGrid1)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel)
        Me.DoRefresh = False

        Me.cmb_PrintType.Items.Clear()
        Me.cmb_PrintType.Items.Add(0, "None")
        Me.cmb_PrintType.Items.Add(1, "Code")
        Me.cmb_PrintType.Items.Add(2, "Code+Name")

        objCompDef = New clsTFCompDefBase(Me.Controller)
    End Sub
    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim dt1 As DataTable, gRow As UltraGridRow, nr, nr2 As DataRow

        Me.FormPrepared = False
        If Me.GetSoftData(oview, prepMode, prepIdx) Then
            Try
                fp = CType(CType(oview.fParentWin, frmTFCompDefParamList).fp, frmTFCompDefBase)

                If myUtils.cValTN(fp.myRow("intdesigncode")) > 0 Then
                    EnableCheckBox = fp.IsDevApp
                Else
                    EnableCheckBox = True
                End If


                Me.chk_ShowInherited.Visible = EnableCheckBox
                dt1 = fp.fPrmList.myView.mainGrid.myDS.Tables(0).Clone
                dt1.Columns.Add("Type", GetType(String))
                For Each str1 As String In New String() {"iscalculated", "islocal", "isvolatile"}
                    dt1.Columns.Add(str1, GetType(Boolean))
                Next
                myUtils.MakeDSfromTable(dt1, False)
                For Each r1 As DataRow In fp.fPrmList.mvGloParam.mainGrid.myDS.Tables(0).Select
                    nr2 = objCompDef.myTFCDPrm.AddUpdCompDefParam(dt1, r1, False)
                    nr2("islocal") = 0
                    nr2("type") = "3-Global"
                Next

                Dim strf1 As String = "isnull(itemnumfixed,'')=''"
                Dim strf2 As String = myUtils.CombineWhere(False, strf1, fp.fPrmList.mvInheritParam.mainGrid.myDv.RowFilter)
                For Each r1 As DataRow In fp.fPrmList.mvInheritParam.mainGrid.myDv.Table.Select(strf2)
                    nr2 = objCompDef.myTFCDPrm.AddUpdCompDefParam(dt1, r1, False)
                    nr2("islocal") = 0
                    nr2("type") = "2-Inherited"
                Next
                For Each r1 As DataRow In fp.fPrmList.myView.mainGrid.myDS.Tables(0).Select(strf1)
                    nr2 = objCompDef.myTFCDPrm.AddUpdCompDefParam(dt1, r1, False)
                    nr2("islocal") = 1
                    nr2("type") = "1-Local"
                Next

                myView.mainGrid.MainConf("HIDECOLS") = myWinData.GenColList(Me.Controller.Data.SelectCols(dt1, "", "*"), "ParamCode, ParamName, DataType, Formula, Type")
                myView.myMode = EnumViewMode.acSelectM : myView.MultiSelect = True
                myView.mainGrid.BindView(dt1.DataSet, , 0)
                myView.mainGrid.MainConf("CONSUMEHIDECOLSWIDTH") = False
                myView.mainGrid.MainConf("sortcolsasc") = "type,paramcode"
                myView.mainGrid.QuickConf("", True, "1-4-1-4-2", True)
                For Each str1 As String In Split(myUtils.cStrTN(myRow("tfcompdefparamcodes")), ",")
                    gRow = myWinUtils.FindRow(myView.mainGrid.myGrid, "paramcode", str1, True)
                    If Not gRow Is Nothing Then myWinUtils.DataRowFromGridRow(gRow)("sysincl") = True
                Next
                If EnableCheckBox Then Me.reCalcParams(myUtils.cBoolTN(myRow("showinherited"))) Else Me.reCalcParams(False)

                Me.txt_PrintTypeFormula.InitFCheck(fp.dtAllParams, fp.oWOInfo, "")

                Me.FormPrepared = True
            Catch ex As Exception
                Debug.WriteLine("Wrong parent!")
            End Try



            
        End If
        Return Me.FormPrepared

    End Function
    Public Overrides Function VSave() As Boolean
        Dim str1 As String = ""

        Me.InitError()
        If myUtils.cStrTN(Me.txt_GroupName.Text).Trim.Length = 0 Then WinFormUtils.AddError(Me.txt_GroupName, "Enter Group Name")
        If myView.mainGrid.myDS.Tables(0).Select("sysincl=1").Length = 0 Then WinFormUtils.AddError(Me.txt_GroupName, "Select Parameters")
        If Me.CanSave Then
            For Each r1 As DataRow In myView.mainGrid.myDS.Tables(0).Select("sysincl=1", "paramcode")
                str1 = str1 & IIf(str1 = "", "", ",") & myUtils.cStrTN(r1("paramcode"))
            Next
            myRow("tfcompdefparamcodes") = str1
            Me.SaveSoftData()
            VSave = True
        End If

    End Function

    Private Sub chk_ShowInherited_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_ShowInherited.CheckedChanged
        Me.reCalcParams(Me.chk_ShowInherited.Checked)
    End Sub
    Private Sub reCalcParams(showinherited As Boolean)
        If showinherited Then
            myView.mainGrid.myDV.RowFilter = ""
        Else
            myView.mainGrid.myDV.RowFilter = "islocal=1"
        End If
        myView.mainGrid.HighlightRows()

    End Sub

End Class


