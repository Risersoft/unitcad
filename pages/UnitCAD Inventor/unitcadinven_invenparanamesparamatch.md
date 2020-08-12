---
title: Parameter Matching
keywords: Parameter Matching
sidebar: unitcad-inventor_sidebar
permalink: unitcad-inventor/parameter-matching.html
folder: UnitCAD Inventor
hide_sidebar: false
comments: false
---
# Parameter Matching


![](/images/component-defition-invenparanems.jpg)


In the Parameters tab, a mapping column shows whether UnitCAD finds the parameter in the global parameter list or the local parameter list or does not find the mapping at all.

If all parameters are mapped, the bar at the bottom will be green. Even if one parameter is unmapped, the bar will be red. Now either you can go ahead and add global parameters and press the refresh button or you can manually add local parameters matching with the block parameters.

You can also press the “Copy unmapped parameters to local parameters” button to automatically create local parameters with the same code as the unmapped parameters. Then you need to go to to the local parameters tab to define the formulaes for each one of them.

Once all parameters have been mapped, you can press the “Calc Params” button to calculate parameter values.

![](/images/component-defition-calc.jpg)

This will put the new values next to the model values. If you want to test what the block will look like with the updated values, you can press the “Set Parameters and Update”. This will update the current document with the new values of parameters.

The check tab can be used to perform some live calculations on the calculated parameters.

![](/images/component-defition-test.jpg)

This formula tester is different from the others in the fact that the formula values are taken from the global parameters as defined for “WO for testing Parameters” and local parameters as defined in the component.

The build referenced parameter list button is therefore disabled.

One thing to note here is that parameters will be loaded in the formula checker only if a formula or a value has been defined for them. So if you see a #REF error, it either means the reference could not be found because it was not there or it has no value or formula assigned.
