---
title: VSave
keywords: VSave
sidebar: mvcwf_sidebar
permalink: web-development-workflow/vsave.html
folder: Workflow
hide_sidebar: false
comments: false
---




#  VSave

When we save our form VSave method is called.

```

Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            If Me.CanSave Then
Dim ewaybillDescrip As String = " EwayBillNo: " & myUtils.cStrTN(myRow("EWayBillNum")) & ", Dt. " & myUtils.cDateTN(myRow("EWayBillDate"), DateTime.MinValue)
                Try  
                  myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "ewaybillID", frmIDX)

                    Dim oProc As New clsGSTEWB(myContext)
                    oProc.PopulateCalc(myUtils.cValTN(myRow("ewaybillID")), myRow.Row, dicObjects("gstreg"), dsForm.Tables("EWayBillItem"), Nothing, Nothing, Nothing, dsCombo)

                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                    frmIDX = myRow("ewaybillID")

                    frmMode = EnumfrmMode.acEditM
                    myVueVehicle.MainGrid.SaveChanges(, "ewaybillID=" & frmIDX)
                    myUtils.ChangeAll(dsForm.Tables("EWayBillItem").Select, "ewaybillID=" & frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(dsForm.Tables("EWayBillItem"), "Select EWayBillItemID,EWayBillID,LineSNum,Description,Details,Hsn_sc,Uqc,Qty,TXVAL,RT,Cess_RT,IAMT,CAMT,SAMT,CSAMT from EWayBillItem")

myRow("lastvehicleid") myUtils.MaxVal(myVueVehicle.MainGrid.myDS.Tables(0).Select, "ewaybillvehicleid")
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                       myContext.Provider.dbConn.CommitTransaction(ewaybillDescrip, frmIDX)
                    VSave = True

                Catch ex As SqlException
                    myContext.Provider.dbConn.RollBackTransaction(ewaybillDescrip, ex.Message)
                    Me.AddError("", ex.Message)
                End Try
            End If
        End If
    End Function
```

