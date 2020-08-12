---
title: Tutorial 1 - Using AutoCAD parametric blocks
keywords: Tutorial 1 - Using AutoCAD parametric blocks
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/tutorial1-using-autocad-parametric-blocks.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Tutorial 1 - Using AutoCAD parametric blocks



Launch UnitCAD and select “Component Definitions” from the “List” menu.


![](/images/comp-list-menu.jpg)


Select “File / Parent Component Definition 2D” from the New Menu.

![](/images/parent-component-definition-2d.jpg)



You may be presented with a screen which asks you to select a work order. Select “Demo Order for Demo Customer”

Make entries as below in the component definition screen.


![](/images/demo-order-for-demo-customer.jpg)


Go to Component tab and click Browse.  Select the file “TIE-ROD.dwg” from the samples folder.

When you select it, following will be shown:


![](/images/component-browse.jpg)


Click on the tie-rod block in the bottom left corner and the block preview will be shown if available. Click on the parameters tab.


![](/images/component-para-tab.jpg)


UnitCAD maps parameters in the block with the parameters in the component definition. Red means all parameters have not been mapped. Attributes are also shown in the list but they can be mapped or unmapped.

Click Copy Unmapped to local parameters.


![](/images/component-copy.jpg)


TRL, TRD and TR_REG were copied to the list of local parameters. UnitCAD now finds the mapping and hence the color turns green.

Now go over to the Parameters tab. The three parameters will be listed. Edit each one of them using the “Edit” button and enter formulas so that the screen looks like the following:


![](/images/component-definition.jpg)


Now Press the Test Component button at the bottom left.

The CAD Maker window will be shown:


![](/images/cad-maker.jpg)


In the background, a new AutoCAD drawing is created.


![](/images/drawing.jpg)


If you select the geometry, you will the model has been updated with new values.
