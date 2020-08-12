---
title: Parameter override
keywords: Parameter override
sidebar: unitcad-inventor_sidebar
permalink: unitcad-inventor/parameter-override.html
folder: UnitCAD Inventor
hide_sidebar: false
comments: false
---


# Parameter override



Whenever a component is called as a child from a parent component, its local parameters can be overridden by the parent.

![](/images/component-defition-childpara.jpg)

This facility provides an opportunity for the parent to provide the child with the parameters it likes. As a component author, we use this facility to write modular components that can be called from many different parents.

The default behavior of any component is to preserve all local parameters unless overridden specifically by the immediate parent using the dialog box given above. Generally this behavior “Local overrides Parent” is all you need and will be used if nothing is selected in the “Parameter behavior in case of conflict” combo box in the component definition screen

However you can change this behavior. If you select “Parent overrides local”, all parameters in the scope of the parent would be used by the child even if the parent does not specifically override.

If you select “local parameters not required”, all parameters in the component that are not present in the scope of the parent will be discarded. This is used by all UnitCAD internal components like line, circle etc.

Some components are designed to be “generic” components suitable to be called by any parent. Internal UnitCAD components such as “line”, “Rectangle” etc are such examples. You may have some generic components of your own such as “four holes with a centre hole” or “” ladder with fixed pitch” etc.

Some components are designed to be “specific” components. Generally these would relate global parameters to the child components.
