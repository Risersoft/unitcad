---
title: Quantity
keywords: Quantity
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/quantity.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Quantity



Qty Formula text box can be used to define quantity. If this is constant, you can just enter a number. If it is formula based, you can use the formula tester as already described.

UnitCAD makes only one block definition per child. If quantity can be more than 1, UnitCAD inserts the same block definition. The position of the inserted block may be different for each one of them. If you need to have same component child called with different parameters, you need to call the same child again using Add in the Children tab.

In the conditional selection of child tab, we can write a formula that evaluates to a component code. If this formula is defined, the combo box dropdown selection is ignored.

If you happen to have several if statements in the formula, you might consider using Design Table Based Components given later in the documentation.
