---
title: Prepform
keywords: Prepform
sidebar: mvcwf_sidebar
permalink: web-development-workflow/prepform.html
folder: Workflow
hide_sidebar: false
comments: false
---



#  Prepform

This method is used to check mode of the form (add/edit) and set values accordingly. In prepform Gridviews are also created and filled with required data.


Gridviews are used to get or post data from/in multiple tables at the same time. One gridview corresponds to one table in database.

```

Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String, oMasterData As New clsMasterDataHRP(myContext)
        Dim ds As DataSet

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select *, 0 as CompanyID from Employees where employeeid = " & prepIDX
        Me.InitData(sql, "personid", oView, prepMode, prepIDX, strXML)

        Dim dic As New clsCollecString(Of String)
dic.Add("fullname", "select fullname from persons where personid =" & myUtils.cValTN(myRow("personid")))
dic.Add("employeeid", "select employeeid From employees where leavedate is null and personid = " & myUtils.cValTN(myRow("personid")))
        dic.Add("VendorCode", "select * from vendor where employeeid = " & frmIDX)
        ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
If ds.Tables(0).Rows.Count > 0 Then Me.ModelParams.Add(New clsSQLParam("@Name", "'" & ds.Tables(0).Rows(0)("fullName") & "'", GetType(String), False))
If (ds.Tables(1).Rows.Count > 0) AndAlso (frmMode = EnumfrmMode.acAddM) Then Me.AddError("EmpCode", "This person is already added as an Employee")
        If ds.Tables("VendorCode").Rows.Count = 0 Then
        Me.ModelParams.Add(New clsSQLParam("@VendorCode", "'" & "Not Defined" & "'", Get-Type(String), False))
        Else
        Me.ModelParams.Add(New clsSQLParam("@VendorCode", "'" & ds.Tables("vendorcode").Rows(0)("vendorcode") & "'", GetType(String), False))
        End If

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

```

