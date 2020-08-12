---
title: How to define in AutoCAD
keywords: How to define in AutoCAD
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/how-to-define-in-autocad.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# How to define in AutoCAD

![](/images/how-to-define-in-autocad.jpg)

In AutoCAD bring up the parameters manager palette by clicking on the parameters manager button on the ribbon bar in the parametric tab. This palette contains both “dimensional constraint” parameters and the user parameters.  The dimensional constraint parameters can be related to the user parameters so that when the user parameter changes, the model is updated.

UnitCAD collects information about User Parameters and lists them in the component definition screen. Hence these blocks have to be defined in such a way that changing the user parameters results into the desired effect. Of course, if the block is getting too complex, we need to break it down into more no. of simpler blocks or use UnitCAD internal geometry creation components such as line, circle etc to get the desired output.

You can also define expression for User Parameters in the AutoCAD window itself. If this is done, UnitCAD would not update such a parameter and its value would be automatically updated by AutoCAD based on the value of other parameters.
