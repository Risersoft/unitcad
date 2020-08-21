---
title: Exporting and Importing
keywords: Exporting and Importing
sidebar: FormulaCAD-autocad_sidebar
permalink: FormulaCAD-autocad/exporting-and-importing.html
folder: FormulaCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Exporting and Importing



You can share your component definitions using the Export and Import Functionality. All data such as local parameters, children and their parameters, actions etc are included.

To Export, click on the Export Component button in the bottom left of the component definition screen. A file dialog will ask you to select a file name and the extension would be a *.ucadc (FormulaCAD component) file.

To Import, click on the “Import Component Definition” item in the New Menu.

FormulaCAD will ask you to select a FormulaCAD component (*.ucadc) file. When you select this file, a dialog box such as the following will be presented.

![](/images/import-component.jpg)

The code of the component needs to be unique in the database where you are importing the definition. Hence if the code exists, an error dialog box will be shown.

Other important thing is that the children are mapped using codes. All children which could be mapped are shown with green background and which could not be mapped will be shown with a red background.  FormulaCAD will allow you to import even if all mappings are not available. In this case an entry will be added to the children list of component and all parameter overrides will also be added. You can later edit the child link and select appropriate child component.

If you are importing a series of components, it is important to sequence the import in such a manner that most children are found. This will result in minimum work after Import.

Importing of design table based components is currently not supported.
