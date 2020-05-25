---
title: InitViews
keywords: InitViews
sidebar: mvcwf_sidebar
permalink: web-development-workflow/initviews.html
folder: Workflow
hide_sidebar: false
comments: false
---


# 	InitViews

This method is used to get data from multiple tables. Which we can further use as per the requirement.

```

Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Items")
        myVueVehicle = Me.GetViewModel("PartB")
 End Sub
```

