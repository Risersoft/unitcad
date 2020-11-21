Imports risersoft.unitcad
Public Class frmTFCompDef3D
    Implements IDocumentForm

    Public fInv As frmInvDoc

    Public Overrides Sub InitViewer3D()
        fInv = New frmInvDoc
        AddHandler fInv.DocParamChanged, AddressOf HandleParams
        AddHandler fInv.btnCopyUnused.Click, AddressOf btnCopyUnused_Click
        AddHandler btn_GenChildrenLeaf.Click, AddressOf btn_GenChildrenLeaf_Click
        AddHandler btnGenEnt.Click, AddressOf btnGenEnt_Click
        AddHandler btnGenWorkFeat.Click, AddressOf btnGenWorkFeat_Click
        AddHandler btn_TakeShots.Click, AddressOf btn_TakeShots_Click
        AddHandler btnMakeModel.Click, AddressOf btnMakeModel_Click
        AddHandler btnApplyActions.Click, AddressOf btnApplyActions_Click
        AddHandler btnApplySelected.Click, AddressOf btnApplyActions_Click
        fDoc = fInv
        pnl = fInv.PanelBot
    End Sub

    Private Sub btn_GenChildrenLeaf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If fInv IsNot Nothing Then myIAM.GenChildrenLeaf(Me.Controller, fInv.LoadedFile, myVueBOM.Model)
    End Sub

    Private Sub btnGenEnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If fInv IsNot Nothing Then
            If myDWG.InProcInv Then
                myIAM.GenEntIP(Me.Controller, fInv.LoadedFile, myVueEnt.Model, Me.fInv.objModel)
            ElseIf TypeOf fInv.fView Is frmIVCHost Then
                myIAM.GenEntOP(CType(fInv.fView, frmIVCHost).AxInventorViewControl1.ApprenticeServerDocument, myVueEnt.Model, Me.fInv.objModel)
            End If
        End If
    End Sub

    Private Sub btnGenWorkFeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If fInv IsNot Nothing Then myIAM.GenWorkFeat(Me.Controller, fInv.LoadedFile, myVueEnt.Model, Me.fInv.objModel)
    End Sub

    Private Sub btn_TakeShots_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TakeShots3D(sender)
    End Sub

    Private Async Sub btnMakeModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.VSave Then
            cm.EndCurrentEdit()
            dsCompDef = myIntent.LoadComponentDefData(Me.Controller, True)
            Me.CalcInherit()
            fInv.TryInitCADProvider()
            If (Not fInv.provider Is Nothing) Then
                Dim mTemp As clsTreePass = objCompDef.PrepareTree(Nothing, oWO, "demo1", myRow.Row, dsCompDef, Me.fPrmList.mvGloParam.mainGrid.myDS.Tables(0), False)
                Dim f As New frmUC3Out
                f.Size = Me.UltraTabControl1.Size
                f.Text = "CAD Maker - " & myRow("compdefcode")
                WinFormUtils.CentreForm(f)
                Await f.TestComponent(oWO, frmIDX, dsCompDef, Me.fPrmList.mvGloParam.mainGrid.myDS.Tables(0), mTemp.dtNewRef, mTemp.dtRefParams)
            End If
        End If
    End Sub

    Private Sub SaveAll(ByVal oDoc As Inventor.Document)
        For Each oDoc2 As Inventor.Document In oDoc.AllReferencedDocuments
            oDoc2.Save()
        Next
    End Sub

    Private Sub btnApplyActions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ApplyAction3D(sender)
    End Sub

    Public Sub ApplyAction3D(ByVal sender As Object)
        Dim str1 As String = ""
        If Me.fInv.oNewDoc Is Nothing Then
            If Not myIAM.oInvApp(Me.Controller) Is Nothing Then Me.fInv.oNewDoc = myIAM.mApp.ActiveDocument
        End If
        If Not Me.fInv.oNewDoc Is Nothing Then
            Me.dsCompDef = myIntent.LoadComponentDefData(myWinApp, False)
            Dim dtp1 As DataTable = Me.dtAllParams.Copy
            myParams.CalcFormulas(oWO.cManager, dtp1)
            If CType(sender, Infragistics.Win.Misc.UltraButton) Is Me.btnApplySelected Then
                For Each r1 As DataRow In Me.myVueAct.mainGrid.myDS.Tables(0).Select("sysincl=1")
                    str1 = str1 & IIf(str1 = "", "", ",") & r1("tfcompdefactpackid")
                Next
                If str1 = "" Then str1 = "0"
                str1 = "tfcompdefactpackid in (" & str1 & ")"
                myIntent3D.DoActions3D(Me.Controller, Me.fInv.oNewDoc, Nothing, Me.frmIDX, Me.dsCompDef, dtp1, oWO.cManager, str1)
            Else
                myIntent3D.DoActions3D(Me.Controller, Me.fInv.oNewDoc, Nothing, Me.frmIDX, Me.dsCompDef, dtp1, oWO.cManager)
            End If
            Me.fInv.oNewDoc.Update2()
            Me.fInv.oNewDoc.Save()
        End If
    End Sub

    Public Sub TakeShots3D(ByVal sender As Object)
        Dim str1 As String = ""
        If Me.fInv.oNewDoc Is Nothing Then
            If Not myIAM.oInvApp(Me.Controller) Is Nothing Then Me.fInv.oNewDoc = myIAM.mApp.ActiveDocument
        End If
        If Not Me.fInv.oNewDoc Is Nothing Then
            Me.dsCompDef = myIntent.LoadComponentDefData(myWinApp, False)
            myIntent3D2.TakeShots3D(oWO, Me.fInv.oNewDoc, Nothing, Me.frmIDX, Me.dsCompDef, Me.dtAllParams, oWO.cManager)
        End If
    End Sub

    Public Sub OnCloseDocument(sender As Object, fullDocumentName As String) Implements IDocumentForm.OnCloseDocument
        'TODO: Update Zip File
    End Sub

    Public Function Id() As String Implements IDocumentForm.Id
        Return "CompDef:" & myUtils.cValTN(myRow("tfcompdefid"))
    End Function

    Public Function AttachedFileName() As String Implements IDocumentForm.AttachedFileName
        Return fInv.LoadedFile
    End Function




    'Public Overrides Function OnFormVSave() As Boolean
    '    If myUtils.cValTN(myRow("dtbased")) = 0 AndAlso myView.mainGrid.myDS.Tables(0).Select("isnull(inheritparams,0)=0 and isnull(inheritactpack,0)=0").Length > 0 Then
    '        If myUtils.cStrTN(myRow("compfilename")).Trim.Length > 0 Then
    '            Dim extfile As String = System.IO.Path.GetExtension(myRow("compfilename"))
    '            If myUtils.InStrList(extfile, "ipt") Then
    '                myRow("Createnewasm") = True
    '                SQLHelper.SaveResults(myRow.Row.Table, "select tfcompdefid,createnewasm from tfcompdef where tfcompdefid=0")
    '            End If
    '        End If
    '    End If
    '    Return True
    'End Function
End Class