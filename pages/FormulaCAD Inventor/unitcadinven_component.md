---
title: Components
keywords: Components
sidebar: FormulaCAD-inventor_sidebar
permalink: FormulaCAD-inventor/components.html
folder: FormulaCAD Inventor
hide_sidebar: false
comments: false
---

# Components



Components are the basic building block - unit of FormulaCAD.  Basically a component is a reusable modular definition of geometry.

A component generates by a combination of the following three methods:

1.  Calling an existing Inventor ipt or iam file.



2.  Calling child components which have been already defined above.



3.  Defining Actions such as Mate, Flush, Insert etc.

To define a component, select “File/Parent Component Defintiion” from the New menu.

When run for the first time, a dialog box such as the following is displayed:

![](/images/FormulaCAD-jobs.jpg)

This is used to select a job which shall be used to test components.  This can be changed later from inside the component definition screen.

Once selected, the component definition screen is displayed

![](/images/component-defition.jpg)

**Code** – This is used to identify the component and needs to be unique.

**Group** – In the list of component definition, components are displayed group-wise. You can enter a new group or select from the list of previously defined groups.

**Description** – Used for some useful description of the component

All new FormulaCAD components are created as Inventor Assemblies. If an Inventor file has been called, it is imported as it is into the main assembly after copying to work order folder. You may however choose to create a new containing assembly and then insert the assembly as a child to this containing assembly. If this is the case select “Create containing assembly for this component definition”. Please note that if component file linked is a part file and children have been defined, then this option is automatically checked.

If you do not want to copy a file to the work order folder, you may select “Treat as library component”

**Parameter Behavior** - Please refer Local Parameters.


