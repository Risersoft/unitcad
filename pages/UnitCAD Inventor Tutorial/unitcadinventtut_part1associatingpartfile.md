---
title: Part#1 – Associating a Part File
keywords: Part#1 – Associating a Part File
sidebar: unitcad-inventor-tutorial_sidebar
permalink: unitcad-inventor-tutorial/Part1–associating-a-part-file.html
folder: UnitCAD Inventor Tutorial
hide_sidebar: false
comments: false
---

# Part #1 – Associating a Part File

Select File/Parent Component Definition 3D from the new menu

![](/images/assemble.jpg)

You may be presented with a screen which asks you to select a work order. Select “Demo Order for Demo Customer”

Make entries as below in the component definition screen.

![](/images/demo-order-for-demo-customer.jpg)

Go to Component tab and click Browse.  Select the file “S012009-6 Globe Valve 80 NB.ipt” from the samples folder.

When you select it, following will be shown

![](/images/globe-valve.jpg)

This particular part file has no parameters defined within it. Since this is a part file, a single node representing this part shows up in the model tree.

We can now press OK to create this component definition inside UnitCAD.

![](/images/show-model-tree.jpg)

The new component definition will show up in the components list and the part file will remain open.

Now let us define the entities inside this part file:

Go to Tools tab in Inventor ribbon bar and click on Entity Marker.

![](/images/entity-marker.jpg)

Entity marker allows you to view / edit / add /delete entities in a part or assembly file. As you can see in this screen, two edges have been defined in this part file. If you click on any entity in this list, UnitCAD will highlight the same in the model.

![](/images/view-assemble-file.jpg)

So now we know that Edge1 and Edge2 are two entities defined in this component. Close the entity marker and the valves.ipt file. Next time, whenever we open this component definition, UnitCAD will open the associated file in Inventor.
