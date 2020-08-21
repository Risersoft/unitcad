---
title: Part#2 – Associating an Assembly File and Parameters
keywords: Part#2 – Associating an Assembly File and Parameters
sidebar: FormulaCAD-inventor-tutorial_sidebar
permalink: FormulaCAD-inventor-tutorial/Part2-associating-an-assembly-file-and-parameters.html
folder: FormulaCAD Inventor Tutorial
hide_sidebar: false
comments: false
---

# Part #2 – Associating an Assembly File and Parameters

Select a new file/parent component definition and make entries as below.

![](/images/component-defi1.jpg)

Go to the Component tab and click Browse.  Select the file “PipeandFlange.iam” from the samples folder. You may have to change the file type while selecting the file in the Open file dialog box.

When you select it, following will be shown

![](/images/component-defi-select.jpg)

Since this is an assembly, the model tree shows the assembly hierarchy on the left. On the right, we see all user parameters that have been defined in the assembly.

FormulaCAD maps parameters in the block with the parameters in the component definition. Red color at the bottom means all parameters have not been mapped.

We can copy all parameters by clicking “Copy Unmapped to local parameters”.  We can also add an individual parameter in the Local Parameters screen and write a formula for setting its value. As we add local parameters, they will show up in the mapping column.

We can define the parameter value in a parent level definition also. Whenever a child component is called by FormulaCAD, all parameters in context are scanned and parameters with matching names are set. Others are left untouched to retain their original values. We will see how this works in the next part.

Open the entity marker from the Tools tab on the ribbon bar to get the following:

![](/images/copy-parameter.jpg)

As we can see, FormulaCAD lists all entities defined for all parts in this assembly. We will need to choose these entities when we apply dynamic constraints in part #3. Note that if a part has multiple instances, FormulaCAD will highlight the entity in all instances.
