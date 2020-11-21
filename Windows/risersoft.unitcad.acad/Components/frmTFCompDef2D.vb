
Imports Autodesk.AutoCAD.Interop
Imports AutoCAD

'should not call acMgd or acDBMdg because this form might be running from outside of AutoCAD
Public Class frmTFCompDef2D
    Public fDwg As frmDwgDoc
    Public Overrides Sub InitViewer2D()
        fDwg = New frmDwgDoc
        AddHandler fDwg.DocParamChanged, AddressOf HandleParams
        AddHandler fDwg.btnCopyUnused.Click, AddressOf btnCopyUnused_Click
        AddHandler Me.btnMakeModel.Click, AddressOf btnMakeModel_Click
        If (Not fDwg.fView.MainMenuStrip Is Nothing) Then fDwg.fView.MainMenuStrip.Enabled = False
        fDoc = fDwg
        pnl = fDwg.PanelBot
    End Sub

    Private Sub btnMakeModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.VSave Then
            cm.EndCurrentEdit()
            dsCompDef = myIntent.LoadComponentDefData(Me.Controller, True)
            Me.CalcInherit()
            fDwg.TryInitCADProvider()
            If (Not fDwg.provider Is Nothing) Then
                Dim f As New frmTCMake
                f.Text = "CAD Maker - " & myRow("compdefcode")
                WinFormUtils.CentreForm(f)
                f.TestComponent(oWO, myRow.Row, dsCompDef)
            End If
        End If
    End Sub


    Protected Overrides Sub OnFrmModeChanged(value As EnumfrmMode)
        If Not fDwg Is Nothing Then fDwg.frmMode = value
    End Sub

End Class