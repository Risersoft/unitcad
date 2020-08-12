---
title: Mommy Calling – Parent Components
keywords: Mommy Calling – Parent Components
sidebar: unitcad-inventor_sidebar
permalink: unitcad-inventor/mommy-calling-parent-components.html
folder: UnitCAD Inventor
hide_sidebar: false
comments: false
---
# Mommy Calling – Parent Components



To add a child to a component, select the Children tab and press the Add button.

![](/images/mommy-calling.jpg)

Code and Description are linked text boxes - either one can be used to select the component code or description and the other will be automatically updated.

You can provide a New Name for this component. This is essential if you are adding the same component twice with different parameters. Basically each component added by UnitCAD is assigned a name and then this name can be used to refer it when we add actions to it such as move etc. or when we reference geometry to it.

## Quantity



Qty Formula text box can be used to define quantity. If this is constant, you can just enter a number. If it is formula based, you can use the formula tester as already described.

UnitCAD makes only one assembly per child. If quantity can be more than 1, UnitCAD inserts the same assembly. The position of the inserted block may be different for each one of them. If you need to have same component child called with different parameters, you need to call the same child again using Add in the Children tab or check the “Create copy of component” check box.

In the conditional selection of child tab, we can write a formula that evaluates to a component code. If this formula is defined, the combo box dropdown selection is ignored.

If you happen to have several if statements in the formula, you might consider using Design Table Based Components given later in the documentation.

## Overriding parameters

![](/images/overriding-parameters.jpg)


To form the chain of components, it is often essential to override the parameters of the child. To do so, you press the add new button and are presented with the following screen:

![](/images/overriding-childparameters.jpg)

The Parameter code combo box lists all parameters for all components. This is essential because conditional selection of child is allowed.  You need to select the code of the parameter to be overridden and then type in the formula. You can use the formula checker as usual.

You can also use the Copy from Child button in the Parameters Value / Override tab. In general, this would copy over all local parameters defined in the child component with their formulas. You can then delete the ones you do not wish to override / re-define and leave the ones you need to specify. You then edit them one-by-one to desired values / formulas.

In case parameter groups have been defined (which you will see later in this section), you will be presented with a dialog box to choose which parameter group you wish to override and parameters belonging to the selected group will be copied.  You can also use the parameter group functionality to limit the parameters that are copied over by default to be over-ridden. One of the next sections tells you how.