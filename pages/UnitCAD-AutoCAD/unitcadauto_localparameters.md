---
title: Local Parameters
keywords: Local Parameters
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/local-parameters.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Local Parameters



Local parameters are parameters that are defined in the scope of the component. Unlike global parameters, which are available to all components, local parameters are available only in the scope of component where they are defined.

Generally local parameters serve the following purpose:

1.  A local parameter can be primarily intended to be over-ridden or used by a parent component



2.  A local parameter can be primarily intended to calculate some value based on global parameters, other local parameters and/or design table.



The value of local parameter, either over-ridden by a parent or calculated by the component, can then be used to provide value to the child components and/or actions defined inside the component.



## Defined in Components

![](/images/define-component-definition-parameters.jpg)

To define a local parameter, select add in the local parameter tab of the component definition screen. A dialog box will be displayed:

**Code** – This is used to identify the parameter and needs to be unique. Same character restrictions as the global parameter apply.

**Name** – Used to provide name which will be displayed alongside code for easy identification.

**Data Type** – These are same as the global parameters but an additional type “Array” is listed here.

The list or array datatype can be used to make lists of points used by certain UnitCAD entities such as Polyline etc.

**Formula** – This is used to define the local parameter. It can be a simple value like “1” or a formula which references global parameters or other local parameters.


## Parameter Override



Whenever a component is called as a child from a parent component, its local parameters can be overridden by the parent.

![](/images/parameter-override.jpg)

This facility provides an opportunity for the parent to provide the child with the parameters it likes. As a component author, we use this facility to write modular components that can be called from many different parents.

The default behavior of any component is to preserve all local parameters unless overridden specifically by the immediate parent using the dialog box given above. Generally this behavior “Local overrides Parent” is all you need and will be used if nothing is selected in the “Parameter behavior in case of conflict” combo box in the component definition screen

However you can change this behavior. If you select “Parent overrides local”, all parameters in the scope of the parent would be used by the child even if the parent does not specifically override.

If you select “local parameters not required”, all parameters in the component that are not present in the scope of the parent will be discarded. This is used by all UnitCAD internal components like line, circle etc.

Some components are designed to be “generic” components suitable to be called by any parent. Internal UnitCAD components such as “line”, “Rectangle” etc are such examples. You  may have some generic components of your own such as “four holes with a centre hole” or “”ladder with fixed pitch” etc.

Some components are designed to be “specific” components. Generally these would relate global parameters to the child components.
