---
title: Components
keywords: Components
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/components.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Components



Components are the basic building block - unit of UnitCAD.  Basically a component is a reusable modular definition of geometry.

A component generates by a combination of the following three methods:

1.  Calling a pre-defined AutoCAD parametric block

Refrence to a DWG file and block name is defined the component.



2.  Calling child components

a.  User-defined components

Any component can be called by a parent component



b.  System defined components such as line,circle etc.

A vast library of AutoCAD entities has been provided with UnitCAD which can be called in user-defined component definitions.



3.  Defining Actions such as Move,Rotate, Mirror etc.

To define a component, select “File/Parent Component Defintiion” from the New menu.

When run for the first time, a dialog box such as the following is displayed:

![](/images/components-unitcad-jobs.jpg)

This is used to select a job which shall be used to test components.  This can be changed later from inside the component definition screen.

Once selected, the component definition screen is displayed

![](/images/components-compon-defi.jpg)

**Code** – This is used to identify the component and needs to be unique.

**Group** – In the list of component definition, components are displayed group-wise. You can enter a new group or select from the list of previously defined groups.

**Description** – Used for some useful description of the component

All UnitCAD components are created as AutoCAD blocks. If an AutoCAD parametric block is called, it is imported as it is into the new file which is created by UnitCAD for geometry creation. You may however choose to create a new block and then insert the AutoCAD block as a child to this block. If this is the case select “Create containing block definition for this component definition”.

**View** – Generally every UnitCAD component definition will correspond to a view – front view, side view or top view etc. This view name is listed in the list of components and may be used to sort and select components. You may enter or choose or leave empty.

**Parameter Behavior** - Please refer Local Parameters.


