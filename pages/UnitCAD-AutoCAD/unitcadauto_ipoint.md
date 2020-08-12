---
title: iPoint
keywords: iPoint
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/ipoint.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# iPoint



All UnitCAD components except the ones in the group “Internal Entities” are created as AutoCAD blocks. Since blocks can be nested inside each other, this provides a perfect mapping for the hierarchical nature of UnitCAD components.

When a child component is called from a parent, a special parameter called iPoint (short for Insertion point) can be defined in the list of parameter values/overrides. This is a point parameter and takes in a formula such as point (x1, y1) or point (x1, y1,0). This will place the child at the specified point with respect to the origin of the current component.

A special characteristic of the iPoint Parameter is to allow use of [//index] variable. If qty of child is more than 1, UnitCAD will update the value of [//index] parameter and calculate iPoint afresh for each one of them. This allows you to write a formula which evaluates into different insertion points for each one of the child block references.

Internal entities such as line,circle etc have their own set of parameters categorized using Parameter Groups. For those components, the parameters contained in these groups fully define the position and hence no additional parameter is needed. The co-ordinates are all defined with respect to the origin of the current component.
