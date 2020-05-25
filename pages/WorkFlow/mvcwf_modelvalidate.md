---
title: Model Validate
keywords: Model Validate
sidebar: mvcwf_sidebar
permalink: web-development-workflow/modelvalidate.html
folder: Workflow
hide_sidebar: false
comments: false
---





#  Model Validate


After posting data object ,server side validation takes place.

```

Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.myRow("empcode").Trim.Length = 0 Then Me.AddError("empcode", "Enter Code")
If Me.SelectedRow("campusid") Is Nothing Then Me.AddError("campusid", "Enter Campus")
If Me.SelectedItem("haswage") Is Nothing Then Me.AddError("haswage", "Enter Wage/Salary")
If Me.SelectedItem("isworker") Is Nothing Then Me.AddError("isworker", "Enter Staff/Worker")
If Me.SelectedRow("shiftid") Is Nothing Then Me.AddError("shiftid", "Enter Shift")
        If Me.SelectedRow("StatusNum") Is Nothing Then Me.AddError("StatusNum", "Enter Status")
        If Me.SelectedRow("depid") Is Nothing Then Me.AddError("depid", "Enter Dep")
If Me.SelectedRow("divisionid") Is Nothing Then Me.AddError("divisionid", "Enter Division")

If myUtils.cValTN(myRow("leaveAuth1ID")) = myUtils.cValTN(myRow("leaveAuth2ID")) AndAlso myUtils.cValTN(myRow("leaveAuth2ID")) > 0 Then
 Me.AddError("leaveAuth2ID", "LeaveAuthority1 and LeaveAuthority2 can't be same")
        End If
        Return Me.CanSave
    End Function
```

