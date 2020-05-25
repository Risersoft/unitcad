---
title: ParamsOutput
keywords: ParamsOutput
sidebar: mvcwf_sidebar
permalink: web-development-workflow/paramsoutput.html
folder: Workflow
hide_sidebar: false
comments: false
---




#  ParamsOutput


This method is used to get data from server at page load.

```
Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
Dim GstRegID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@gstregid", Params))

             Select Case dataKey.Trim.ToLower
                Case "generate"
Dim EWayBillID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ewaybillid", Params))
                    Dim oProc As New clsGSTNEwayBill(myContext)
                    Dim info = oProc.Generate(GstRegID, EWayBillID)
                    oRet.Success = (info.HttpStatusCode = HttpStatusCode.OK)
                    oRet.Message = info.Message
 oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message, .Data = JsonConvert.SerializeObject(info.Data)}
                Case "cancel"
Dim EWayBillID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ewaybillid", Params))
                    Dim oProc As New clsGSTNEwayBill(myContext)
                    Dim info = oProc.Cancel(GstRegID, EWayBillID)
                    oRet.Success = (info.HttpStatusCode = HttpStatusCode.OK)
                    oRet.Message = info.Message
oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message, .Data = JsonConvert.SerializeObject(info.Data)}

                Case "update"
Dim EWayBillVehicleID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ewaybillvehicleid", Params))
                    Dim oProc As New clsGSTNEwayBill(myContext)
                    Dim info = oProc.Update(GstRegID, EWayBillVehicleID)
                    oRet.Success = (info.HttpStatusCode = HttpStatusCode.OK)
                    oRet.Message = info.Message
oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message, .Data = JsonConvert.SerializeObject(info.Data)}
            End Select
        End If
        Return oRet
    End Function

```

