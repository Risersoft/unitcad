Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics

Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinTree
Imports Infragistics.Win.UltraWinToolbars
Imports risersoft.app.mxent

Public Class frmExplore
    Public fdp As New frmDWGPanel

    Private Sub frmExplore_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        fdp.AddToPanel(Me.SplitContainer1.Panel2, True, DockStyle.Fill)
    End Sub
    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional strXML As String = "") As Boolean
        Dim oWO As clsWOInfoBase = myPIDU.GenerateWOInfo(Me.Controller, prepIDX)
        Return Me.PrepForm(oView, prepMode, prepIDX, oWO)
    End Function

End Class



