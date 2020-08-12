---
title: Entering Parameters
keywords: Entering Parameters
sidebar: unitcad-inventor_sidebar
permalink: unitcad-inventor/entering-parameters.html
folder: UnitCAD Inventor
hide_sidebar: false
comments: false
---
# Entering Parameters



Once work order is define, you can enter parameters. Select “Edit Work Order Parameters” or “Edit Work Order CAD Maker” to go to the parameter entry screen. Edit Work Order CAD Maker consists of two “pages” – the parameter page and the CAD Maker page.

 You can use the “Edit Work Order Parameter” option a) when you know the parameter values but are not yet ready to think about the CAD output. b) If you need to import parameters from Excel File or from a UnitCAD parameters (*.ucadp) file.


## Manual Input

![](/images/work-order-para.jpg)

In this screen you can enter the values manually. Description of the parameter is shown in the lower portion of the screen.

When you go into a parameter which has a design table associated with it, the “Select from design table” button becomes active and when you press this button the design table is shown for selection.

![](/images/work-order-select.jpg)

You need to select the startup component definition and you can select a template file for getting the styles information.

## Importing Parameters from Excel



You can import parameters from Excel file. Excel file should have the following structure

![](/images/import-parameter-structure.png)

When you select xls file, a dialog box such as the following is displayed:

![](/images/import-parameter-excel.png)

This gives the values of all parameters that were identified and their corresponding values. Formulas are updated to get their current value. Upon pressing OK, the values are modified in the parameter entry screen. If some parameters are not found, they are left untouched.


## Importing Parameters from UnitCAD Parameters File

When you need to share components and designs with teams that are not in your campus, you can take advantage of the provision of importing from UnitCAD parameters (*.ucadp) file.

Notable thing here is that you can export and import both the definition and data values. When importing back, UnitCAD provides information on what changes are going to be made in the database.

To Export, click on the “Export to UnitCAD file” button in the Edit Parameters screen. Choose a file name and press save to save the file.

To import, click on the “Import from UnitCAD file” button and select a *. ucadp file. When you do so, a screen such as the following will be presented

![](/images/import-parameter.jpg)

UnitCAD compares the parameter name, group, datatype, design table and the design table column fields to find whether the parameter in database and the one being imported are different. You can choose whether to overwrite such parameters by using the checkbox on the upper left portion. When you press OK, list of global parameters is updated and you see the updated list of parameters in the “Edit Parameters” screen.