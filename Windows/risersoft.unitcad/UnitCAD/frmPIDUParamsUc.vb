Imports System.Windows.Forms
Imports risersoft.app.dataporter
Imports risersoft.app.mxform.eto

Public Class frmPIDUParamsUc
    Inherits frmMax
    Implements ITFSetup
    Implements IfWizMax
    Public fTF As frmWizMax
    Dim bag3 As PropertyTable, compd As Integer, dtp As DataTable
    Private Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

    End Sub

    Public Sub HandleTemplateStartup()
        Dim objDef As New clsTFCompDefBase(Me.Controller)
        compd = objDef.CompTypeApp
        Dim templatevisible = (compd = 2) OrElse (myUtils.cStrTN(myRow("templatefilename")).Trim.Length > 0)

        Me.txt_TemplateFileName.Visible = templatevisible
        Me.lblTemplate.Visible = templatevisible
        Me.cmb_Startupdefid.ReadOnly = (compd = 0) AndAlso (myUtils.cValTN(myRow("startupdefid")) = 0)
    End Sub
    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            dtp = Me.Model.GridViews("params").MainGrid.myDS.Tables(0)
            bag3 = New PropertyTable()
            Me.PropertyGrid1.SelectedObjects = New PropertyBag() {bag3}
            myParams.AddUpdParams(dtp, dtp, bag3, myUtils.cStrTN(myRow("paramgrouppsv")), "desparamid")
            Me.PropertyGrid1.Refresh()
            Me.FormPrepared = True
            If Me.PropertyGrid1.SelectedGridItem Is Nothing Then Me.CheckDesignTable(Nothing) Else Me.CheckDesignTable(Me.PropertyGrid1.SelectedGridItem.PropertyDescriptor)

            HandleTemplateStartup()
            Return True
        End If
        Return False
    End Function
    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPIDUParamsUcModel = Me.InitData("frmPIDUParamsUcModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "compdef", "", Me.cmb_Startupdefid, "<STRWIDTH>0-1-2</STRWIDTH><FORMATXML><COL KEY=""compdefcode"" CAPTION=""Code""/></FORMATXML>")
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function
    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            myParams.SaveBag(bag3, dtp, "desparamid")
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function


    Public Function DoSetup() As Boolean Implements [shared].win.ITFSetup.DoSetup
        Me.Panel2.Visible = False
        Return Me.PrepForm(fTF.myView, EnumfrmMode.acEditM, fTF.frmIDX)
    End Function

    Public Function btnActionText() As String Implements [shared].win.IfWizMax.btnActionText

    End Function

    Public Function LoseFocus(newTabKey As String) As Boolean Implements [shared].win.IfWizMax.LoseFocus
        Dim cont As Boolean
        cont = Me.VSave()
        Return cont
    End Function

    Public Sub PrintOutput() Implements [shared].win.IfWizMax.PrintOutput
    End Sub

    Public Function SetFocus(oldTabKey As String) As Boolean Implements [shared].win.IfWizMax.SetFocus
        Return True
    End Function

    Public Function ShowTabKeys() As System.Collections.ArrayList Implements [shared].win.IfWizMax.ShowTabKeys

    End Function

    Public Sub StartAction() Implements [shared].win.IfWizMax.StartAction

    End Sub

    Public Sub StopAction() Implements [shared].win.IfWizMax.StopAction

    End Sub

    Private Sub btnImport_Click(sender As System.Object, e As System.EventArgs) Handles btnImportXL.Click
        Dim oExim As New clsEXIM(Me.Controller)
        oExim.ImportXL(dtp, Me.PropertyGrid1)
    End Sub

    Private Sub btnExportFile_Click(sender As System.Object, e As System.EventArgs) Handles btnExportFile.Click
        If Me.VSave Then
            Dim oExim As New clsEXIM(Me.Controller)
            oExim.ExportParameters(dtp)
        End If
    End Sub

    Private Sub btnImportFile_Click(sender As System.Object, e As System.EventArgs) Handles btnImportFile.Click
        Dim dt As DataTable
        If Me.VSave Then
            Dim oExim As New clsEXIM(Me.Controller)
            dt = oExim.ImportParameters(myView, frmIDX)
            myParams.AddUpdParams(dt, dtp, bag3, myUtils.cStrTN(myRow("paramgrouppsv")), "desparamid")
            Me.PropertyGrid1.Refresh()
        End If

    End Sub
    Private Sub CheckDesignTable(g As PropertySpecDescriptor)
        Dim r1 As DataRow, desparamid As Integer
        Me.btnSelect.Tag = g

        If g Is Nothing Then
            Me.btnSelect.Enabled = False
        Else
            desparamid = g.item.Tag
            r1 = myParams.ParamRow(dtp, desparamid)
            If myUtils.cValTN(r1("ridestableid")) > 0 Then
                Me.btnSelect.Enabled = True
            Else
                Me.btnSelect.Enabled = False
            End If
        End If

    End Sub
    Private Sub PropertyGrid1_SelectedGridItemChanged(sender As Object, e As System.Windows.Forms.SelectedGridItemChangedEventArgs) Handles PropertyGrid1.SelectedGridItemChanged
        If Me.FormPrepared AndAlso Me.FormShown Then
            Dim g As PropertySpecDescriptor = CType(e.NewSelection.PropertyDescriptor, PropertySpecDescriptor)
            Me.CheckDesignTable(g)
        End If

    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        Dim r1 As DataRow, desparamid, destableid As Integer, dt As DataTable, ret As Object
        Dim g As PropertySpecDescriptor = Me.btnSelect.Tag
        desparamid = g.item.Tag
        r1 = myParams.ParamRow(dtp, desparamid)
        destableid = CInt(r1("ridestableid"))
        dt = myTables.DesignTable(destableid)
        ret = myTables.ShowDesignTable(r1, destableid, dt, Me)
        If Not ret Is Nothing Then
            bag3(g.Name) = CInt(ret)
            Me.PropertyGrid1.Refresh()
        End If

    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click

        Me.OpenFileDialog1.Filter = "DWG Template File (*.dwt)|*.dwt"
        Me.OpenFileDialog1.FilterIndex = 1
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me.txt_TemplateFileName.Text = myPathUtils.RelativePathTo(myWinApp.objAppExtender.FileServerPath, Me.OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Me.txt_TemplateFileName.Text = ""
    End Sub
End Class
