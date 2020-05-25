---
title: InitForm
keywords: InitForm
sidebar: mvcwf_sidebar
permalink: web-development-workflow/initform.html
folder: Workflow
hide_sidebar: false
comments: false
---




#	InitForm

This method is used to fill dsCombo, Valuelists, LookupFields etc. with multiple table’s data that we basically use to fill dropdowns with.

```

Private Sub InitForm()
        Dim sql As String

        sql = "SELECT statusnum, statusText from status where StatusType = 'Emp'"
Me.AddLookupField("statusnum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "status").TableName)

sql = "SELECT userid, username from users where isnull(isdeleted,0)=0 order by username"
        Me.AddLookupField("userid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "user").TableName)

sql = "select campusid, dispname, WODate, CompletedOn from mmlistCampus() order by dispname"
Me.AddLookupField("campusid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "campus").TableName)

        sql = "Select depid, depname, companyid from deps order by depname"
        Me.AddLookupField("depid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "dep").TableName)

sql = "select employeeid,isNull(EmpCode,'') + ' - ' + descrip [EmployeeName], JoinDate, LeaveDate from hrplistallemp() where onrolls=1 order by EmpCode"
Me.AddLookupField("ReportsToID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "rep").TableName)

        sql = "select vendorid, partyname from hrplistparty() order by partyname"
        Me.AddLookupField("ContractorID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "party").TableName)

        sql = "select shiftid, shift from shift order by shift"
        Me.AddLookupField("shiftid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "shift").TableName)

        Dim vlist As New clsValueList
        vlist.Add(False, "Disabled")
        vlist.Add(True, "Enabled")
        Me.ValueLists.Add("EnableList", vlist)
        Me.AddLookupField("ImprestEnabled", "EnableList")
        Me.AddLookupField("PunchEnabled", "EnableList")

        Dim vlst As New clsValueList
        vlst.Add("F", "F - Father")
        vlst.Add("S", "S - Husband")
        Me.ValueLists.Add("Relationship", vlst)
        Me.AddLookupField("Relationship", "Relationship")

        Dim vlst1 As New clsValueList
        vlst1.Add(False, "Salary")
        vlst1.Add(True, "Wages")
        Me.ValueLists.Add("haswage", vlst1)
        Me.AddLookupField("haswage", "haswage")

        Dim vlst2 As New clsValueList
        vlst2.Add(False, "Staff")
        vlst2.Add(True, "Worker")
        Me.ValueLists.Add("isworker", vlst2)
        Me.AddLookupField("isworker", "isworker")

        sql = "SELECT Divisionid, DivisionName  from Division"
        Me.AddLookupField("Divisionid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Division").TableName)

        sql = myFuncs.CodeWordSQL("emp", "leavereason", "")
Me.AddLookupField("LeftReasonCode", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "emp").TableName)


    End Sub

```

