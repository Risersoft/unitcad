---
title: Razorview
keywords: Razorview
sidebar: mvcwf_sidebar
permalink: web-development-workflow/razorview.html
folder: Workflow
hide_sidebar: false
comments: false
---




#  Razorview


After successful execution of prepform() , our view is called/rendered. In our View we import required libraries that helps us maintain no or very less code duplication.

```

@imports risersoft.app.mxform.gst
@ModelType frmGstInvoiceSaleModel

@Code
    ViewData("Title") = "Sale Inovice"
    Layout = "~/Views/Shared/_FrameworkLayout.vbhtml"
    Dim modelJson = Model.SerializeJson()
End Code

```

