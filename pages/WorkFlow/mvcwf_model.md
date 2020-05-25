---
title: Model
keywords: Model
sidebar: mvcwf_sidebar
permalink: web-development-workflow/model.html
folder: Workflow
hide_sidebar: false
comments: false
---



#  Model

After user enters page URL, first call is made to the respective page model. Then the model renders the appropriate view. As we have dynamic controllers which gets created at the time of page call.


```


Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
End Sub

```

