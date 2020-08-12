---
title: Design table based components
keywords: Design table based components
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/design-table-based-components.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Design table based components

In a drawing office, you always have a family of components which have similar characteristics and they need to be called based on parameters. Nuts and Bolts are good examples. Similarly you might have a number of components which you wish to select based on the global parameter inputs.

You can accomplish this using conditional selection of child in the “Add child” dialog box of the component definition screen. You can write a formula using the If function or the Choose function or even the mxlookup function to conditionally select the child based on parameter values.

While that is perfectly fine, UnitCAD offers a more structured built-in approach to handle this situation – Design Table based components. In this case, you define a component for each row of the design table and you define a local parameter which will be used to select the row.

Hence the calling parent just needs to set the value of this one local parameter and voila – you reach to the intended variant comfortably.

## Define New

To Define, select “New design table based component” from the New menu.

![](/images/define-new-component-def.jpg)

Select the Design Table from the “Design Table for Columns” combo box. Design Table for data is automatically filled up. These two fields are almost always the same.

The Select Columns Table in the right will also be populated. You can select which of the columns you wish to display in the list of component in the “Table Rows” tab.

Define a local parameter with an appropriate code and name and select this parameter in the “Local Parameter” combo box. This will be the parameter which will need to be called up by the parent.

## Defining Rows

Once it is set up, select the "Table Rows” tab. This will display two grids one below another. The top grid lists all rows which have been defined. The bottom grid lists all rows which have not been defined.

![](/images/defining-row-comp-def.jpg)

To move from undefined to defined, select any row in the bottom grid, and click “Add”

![](/images/defining-row-comp-def-design-table-row.jpg)

![](/images/defining-row-comp-def-design-table-row2.jpg)

You have two options here – either you can select a child component or select a part file.

 If you select a part file, you see a scaled down version of the information you see when you select a part file in a full blown component definition.

To edit select the row in the top and press edit.

To delete, select any row in the top and press delete. After deletion, this row will move to the bottom grid.


## Calling from parent



Design table based components are called from the parent components just like any other component. UnitCAD finds the appropriate row depending on the value of local parameter for selection in the context of the component. Once this row is found, UnitCAD looks up the row definition to either load a block from a file or move on to the child component defined in the row.

![](/images/calling-from-parent-comp-def.jpg)

![](/images/calling-from-parent-comp-def-child.jpg)
