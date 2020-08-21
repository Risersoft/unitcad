---
title: Testing Components
keywords: Testing Components
sidebar: FormulaCAD-autocad_sidebar
permalink: FormulaCAD-autocad/testing-components.html
folder: FormulaCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Testing Components



Once you have defined all children, and their parameters, you can test the component in the same screen. Global Parameters for the same are provides by the job selected for testing parameters.

To do so, press the test component button on the bottom left of the component definition screen. The CAD Maker window will show up.

![](/images/testing-component-cadmaker.jpg)

This window will list all the steps taken by FormulaCAD in the order of processing. All formula calculation will be shown, in green color. Any errors that come during processing will be shown in red. Other information is all shown in blue. The indentation is varied as per the level of hierarchy.

The CAD maker window provides rich information needed by you to trace and find out what’s happening. You can save the output for later viewing by clicking the “Save output” button.

FormulaCAD always creates geometry in a new AutoCAD file so that any user file is not inadvertently disturbed. The test component button and the create geometry in job screen use the same engine with the difference that the test component places the current component at the top of the component tree.
