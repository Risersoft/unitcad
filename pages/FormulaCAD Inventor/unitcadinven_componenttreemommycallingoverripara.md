---
title: Overriding parameters
keywords: Overriding parameters
sidebar: unitcad-inventor_sidebar
permalink: unitcad-inventor/overriding-parameters.html
folder: UnitCAD Inventor
hide_sidebar: false
comments: false
---
# Overriding parameters

![](/images/overriding-parameters.jpg)


To form the chain of components, it is often essential to override the parameters of the child. To do so, you press the add new button and are presented with the following screen:

![](/images/overriding-childparameters.jpg)

The Parameter code combo box lists all parameters for all components. This is essential because conditional selection of child is allowed.  You need to select the code of the parameter to be overridden and then type in the formula. You can use the formula checker as usual.

You can also use the Copy from Child button in the Parameters Value / Override tab. In general, this would copy over all local parameters defined in the child component with their formulas. You can then delete the ones you do not wish to override / re-define and leave the ones you need to specify. You then edit them one-by-one to desired values / formulas.

In case parameter groups have been defined (which you will see later in this section), you will be presented with a dialog box to choose which parameter group you wish to override and parameters belonging to the selected group will be copied.  You can also use the parameter group functionality to limit the parameters that are copied over by default to be over-ridden. One of the next sections tells you how.
