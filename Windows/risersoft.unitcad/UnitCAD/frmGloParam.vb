Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmGloParam
    Inherits frmMax
    Dim dvCol As DataView

    Public Sub initForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmGloParamModel = Me.InitData("frmGloParamModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            'this form is dedicated for the database TCAD and is not meant for MaxDB
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "destab", "", Me.cmb_RIDestableID, "<STRWIDTH>0-1-2</STRWIDTH>", False, False)
            myWinSQL.AssignCmb(Me.dsCombo, "tablecol", "", Me.cmb_DesTableColID, , 2)
            dvCol = CType(Me.cmb_DesTableColID.DataSource, DataView)

            Me.cmb_DataType.ValueList = Me.Model.ValueLists("DataType").ComboList
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub cmb_RIDestableID_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_RIDestableID.ValueChanged
        Dim gRow As UltraGridRow
        If Me.Formprepared Then
            gRow = Me.cmb_RIDestableID.SelectedRow
            If gRow Is Nothing Then dvCol.RowFilter = "0=1" Else dvCol.RowFilter = "destableid=" & myUtils.cValTN(gRow.Cells("destableid").Value)
        End If
    End Sub
End Class

