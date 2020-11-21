Imports risersoft.app.shared
Imports risersoft.app.shared.mxengg

Public Class frmTFCompDefParamList
    Inherits frmMax
    Public fp As frmMax, dtAllParams, dtAllCompDefParams As DataTable
    Public mvGloParam, mvInheritParam, myVueGrp As New clsWinView
    Dim oSortP As clsWinSort

    Public Sub initForm()
        myView.SetGrid(UltraGrid1)
        mvInheritParam.SetGrid(Me.UltraGrid5)
        mvGloParam.SetGrid(Me.UltraGrid6)
        myVueGrp.SetGrid(Me.UltraGrid14)
        oSortP = New clsWinSort(myView, Me.btnMovePU, Me.btnMovePD, Me.btnRenumP, "sortindex")
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        myView.PrepEdit(fp.Model.GridViews("local"))
        mvGloParam.PrepEdit(fp.Model.GridViews("GloParam"))

        oSortP.reSort()
        mvInheritParam.PrepEdit(fp.Model.GridViews("InheritParam"))
        Return True
    End Function

    Public Sub LoadPIDU(IDFieldRow As DataRow, IDField As String, oWO As clsWOInfoUCAD, OnCtlPIDUChange As Boolean)
        If OnCtlPIDUChange Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@PIDUnitID", myUtils.cValTN(oWO.rPIDU("pidunitid")), GetType(Integer), False))
            Params.Add(New clsSQLParam($"@{IDField}", myUtils.cValTN(fp.myRow(IDField)), GetType(Integer), False))
            Dim dic As clsCollecString(Of clsViewModel) = fp.GenerateParamsModelCollec("paramlist", Params)
            myView.PrepEdit(dic("local"))
            mvGloParam.PrepEdit(dic("gloparam"))
            mvInheritParam.PrepEdit(dic("inheritparam"))
            oSortP.reSort()
        Else
            If Me.BindModel(fp.Model) Then
                'Local Parameter grid is never refreshed usually because frmTFCompDefParam dorefresh is set to false
                Me.frmIDX = myUtils.cValTN(IDFieldRow(IDField))
                Dim GroupVisible As Boolean =
                     (IDFieldRow.Table.Columns.Contains("dtbased")) AndAlso
                     (myUtils.cValTN(IDFieldRow("dtbased")) = 0) AndAlso
                     (fp.Model.GridViews.ContainsKey("grp"))

                If GroupVisible Then
                    Me.UltraTabControlParam.Tabs("grp").Visible = True
                    myVueGrp.PrepEdit(fp.Model.GridViews("grp"))
                Else
                    'bomgadef/assydef/design table based
                    Me.UltraTabControlParam.Tabs("grp").Visible = False
                End If
            End If
        End If
    End Sub

    Public Sub CalcInherit(IDFieldRow As DataRow, IDField As String, dsCompDef As DataSet, dtChild As DataTable)
        dtAllCompDefParams = mvInheritParam.mainGrid.myDS.Tables(0).Copy
        myUtils.ChangeAll(myView.mainGrid.myDS.Tables(0).Select, IDField & "=" & fp.frmIDX)
        myUtils.CopyRows(myView.mainGrid.myDS.Tables(0).Select, dtAllCompDefParams)

        Dim dtBomParam As DataTable = If(dsCompDef Is Nothing, Nothing, dsCompDef.Tables("bomparam"))
        Dim oProc As New clsTFCompDefBase(Me.Controller)
        dtAllParams = oProc.myTFCDPrm.dtCompDefNetParams(IDFieldRow, Nothing, Nothing, mvGloParam.mainGrid.myDS.Tables(0), dtChild, dtAllCompDefParams, dtBomParam, Nothing, Nothing, Me.mvInheritParam.mainGrid.myDv, False, Nothing)
        If TypeOf fp Is frmTFCompDefBase Then CType(fp, frmTFCompDefBase).HandleParams()
    End Sub

    Private Sub btnExportParams_Click(sender As System.Object, e As System.EventArgs) Handles btnExportParams.Click
        Dim oExim As New clsEXIM(Me.Controller)
        oExim.ExportParameters(Me.mvGloParam.mainGrid.myDS.Tables(0))
    End Sub
End Class
