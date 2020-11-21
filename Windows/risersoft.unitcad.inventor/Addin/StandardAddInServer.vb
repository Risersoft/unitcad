Imports System
Imports System.Runtime.InteropServices
Imports System.Diagnostics.CodeAnalysis

Imports Inventor

'------------------------------------------------------------
'// InventorAddIn1 Inventor Add-in
'//  
'// Author: abhishek.singhal
'// Creation date: 5/22/2013 2:56:55 PM
'// 
'------------------------------------------------------------
<ProgId("risersoft.unitcad.iv.StandardAddInServer"),
Guid("360db284-d848-45e2-a61c-35c773f061ad"),
ComVisible(True)>
Public Class StandardAddInServer
    Inherits Autodesk.ADN.InvUtility.AddIn.AdnAddInServer

    Public Overrides Sub Activate(addInSiteObject As ApplicationAddInSite, firstTime As Boolean)

        MyBase.Activate(addInSiteObject, firstTime)
        Dim res As String() =
         Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames()
    End Sub

    Public Overrides Sub Deactivate()

        MyBase.Deactivate()

    End Sub

    Public Overrides ReadOnly Property RibbonResource As String

        Get
            Return "risersoft.unitcad.iv.ribbons.xml"
        End Get

    End Property

End Class


