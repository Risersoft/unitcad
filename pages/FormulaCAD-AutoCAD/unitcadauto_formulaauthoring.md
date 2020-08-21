---
title: Formula Authoring
keywords: Formula Authoring
sidebar: FormulaCAD-autocad_sidebar
permalink: FormulaCAD-autocad/formula-authoring.html
folder: FormulaCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Formula Authoring



Local parameters may have a formula referring to global parameters or other local parameters. In general, FormulaCAD requires you to write a formula at several places.

![](/images/formula-authoring-component-def.jpg)

This section provides general guidelines on how to write a formula.

FormulaCAD provides an easy and powerful way to write formulas. Generally formula writing is very similar to Microsoft Excel, with the following exceptions:

1.  Parameters are referred by enclosing parameter code in square brackets and preceding with a double slash [//paramcode]



2.  Generally FormulaCAD provides all functions available in Excel – and adds a few of its own specific to CAD functionality. Detailed list of functions is available in the appendix.



Wherever a formula is asked for, FormulaCAD provides a handy formula checker to check the syntax and test the formula with various values to see if the values concur with the logic intended.

To use the formula checker, first type the formula in and then press the “Build referenced parameter list “button. FormulaCAD will then list the referred parameters in the box along with a Status column on whether this parameter was found among the list of parameters in scope.

The Value column is a place to fill in your test values. This is deliberately not taken from the defined value of the parameters so as to facilitate testing.

Once test values are filled in the values column of the grid, press the “Test Formula” button. If there is a syntax error, an error will be displayed. If not, a value will be displayed next to the “Formula Value” label near the bottom left. You can fill in various test values and test to verify everything is in order.

A thing to note here is that the [//index] parameter is generally not used in the local parameter formula definition. It is used in two contexts: in the Parameter Values / Override screen and in the Actions screen.
