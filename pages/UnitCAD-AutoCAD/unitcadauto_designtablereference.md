---
title: Design Table Reference
keywords: Design Table Reference
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/design-table-reference.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Design Table Reference



A global parameter can be a row index of a design table. In this case you would still input the value as a number for example 1,2,3 referring to a particular row of a design table.

However a normal feature of design tables is constant addition of data and therefore row indexes are liable to change. In such a case if you open the old job, the row index will likely refer to a wrong row.

UnitCAD offers a solution to this issue. If you define the design table in the “Parameter is row index of design table” box, UnitCAD will store a hidden reference to the row in addition to the row index. If the row index changes, the hidden reference still remains the same and therefore the selection is preserved.



In other cases, you might have a design table to assist in easy data entry – selecting from a list of values instead of typing in. In that case, you define the design table column in addition to the design table itself. In this case no hidden refrences are stored, but during data entry, you can call up the design table and select from the list. The value in the selected row and the column specified in this box will be stored for this parameter.l
