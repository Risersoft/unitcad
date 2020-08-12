---
title: Mommy Calling – Parent Components
keywords: Mommy Calling – Parent Components
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/mommy-calling-parent-components.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Mommy Calling – Parent Components



To add a child to a component, select the Children tab and press the Add button.

![](/images/mommy-calling-component-def.jpg)

Code and Description are linked text boxes - either one can be used to select the component code or description and the other will be automatically updated. The list consists of all internal UnitCAD components as well as user-defined components. In face UnitCAD components such as line,circle etc have been designed in such a fashion so that a consistent interface is presented to the user.

You can provide a New Name for this component. This is essential if you are adding the same component twice with different parameters. Basically each component added by UnitCAD is assigned a name and then this name can be used to refer it when we add actions to it such as move etc. or when we reference geometry to it.

## Quantity



Qty Formula text box can be used to define quantity. If this is constant, you can just enter a number. If it is formula based, you can use the formula tester as already described.

UnitCAD makes only one block definition per child. If quantity can be more than 1, UnitCAD inserts the same block definition. The position of the inserted block may be different for each one of them. If you need to have same component child called with different parameters, you need to call the same child again using Add in the Children tab.

In the conditional selection of child tab, we can write a formula that evaluates to a component code. If this formula is defined, the combo box dropdown selection is ignored.

If you happen to have several if statements in the formula, you might consider using Design Table Based Components given later in the documentation.


## Overriding Parameters

![](/images/overriding-parameter-compo-def-child.jpg)

To form the chain of components, it is often essential to override the parameters of the child. To do so, you press the add new button and are presented with the following screen:

![](/images/overriding-parameter-compo-def-child-parameter.jpg)

The Parameter code combo box lists all parameters for all components. This is essential because conditional selection of child is allowed.  You need to select the code of the parameter to be overridden and then type in the formula. You can use the formula checker as usual.

You can also use the Copy from Child button in the Parameters Value / Override tab. In general, this would copy over all local parameters defined in the child component with their formulas. You can then delete the ones you do not wish to override / re-define and leave the ones you need to specify. You then edit them one-by-one to desired values / formulas.

In case parameter groups have been defined (which you will see later in this section), you will be presented with a dialog box to choose which parameter group you wish to override and parameters belonging to the selected group will be copied. This is used by UnitCAD internal components such as line, circle etc. to present appropriate variant to be created.

![](/images/overriding-parameter-select.jpg)

You can also use the parameter group functionality to limit the parameters that are copied over by default to be over-ridden. One of the next sections tells you how.

## iPoint



All UnitCAD components except the ones in the group “Internal Entities” are created as AutoCAD blocks. Since blocks can be nested inside each other, this provides a perfect mapping for the hierarchical nature of UnitCAD components.

When a child component is called from a parent, a special parameter called iPoint (short for Insertion point) can be defined in the list of parameter values/overrides. This is a point parameter and takes in a formula such as point (x1, y1) or point (x1, y1,0). This will place the child at the specified point with respect to the origin of the current component.

A special characteristic of the iPoint Parameter is to allow use of [//index] variable. If qty of child is more than 1, UnitCAD will update the value of [//index] parameter and calculate iPoint afresh for each one of them. This allows you to write a formula which evaluates into different insertion points for each one of the child block references.

Internal entities such as line,circle etc have their own set of parameters categorized using Parameter Groups. For those components, the parameters contained in these groups fully define the position and hence no additional parameter is needed. The co-ordinates are all defined with respect to the origin of the current component.

## Color, Layer



Color and Layer are also “generic” UnitCAD parameters in that they can be defined for any “Internal Entity” type of component and the color and layer will be accordingly assigned.

Color is defined in terms of Names such as “Red”, “Blue” etc.

Layer is defined in terms of layer name. If the layer already exists in the new model, it will be used. If not, a new layer will be created.

As you can sense, these two properties are also formula driven and so provide a powerful way of organizing your final drawing output.