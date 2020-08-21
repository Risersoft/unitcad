---
title: Arrays
keywords: Arrays
sidebar: FormulaCAD-autocad_sidebar
permalink: FormulaCAD-autocad/arrays.html
folder: FormulaCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Arrays

These components are internal FormulaCAD components. They differ from other internal FormulaCAD components in that their output is a block rather than an AutoCAD entity.

Also, the component which is being “arrayed” will be consumed by this component. Array components have a naming scheme which allows you to uniquely refer to each one of the copy and the name of the original component is also changed to get consistency.

## Rectangular Array

Component Code – ArrayRect

![](/images/rect-array-comp-def-child.jpg)

Naming Scheme is _RxCy where x is the row number and y is the column number. For example, if above parameters are used, Components will have C1_R1C1, C2_R1C2 ….. C1_R2C1, C1_R2C2 and so on.

![](/images/rect-array-drawing5.jpg)


## Polar Array

Component Code – ArrayPolar

![](/images/polar-array-comp-def-child.jpg)

Naming Scheme is _Pn where n is the array index. For example, if above parameters are used, Components will have R1_P1, R1_P2 and so on.

![](/images/polar-array-drawing5.jpg)
