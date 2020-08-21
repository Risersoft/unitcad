---
title: Inheriting components
keywords: Inheriting components
sidebar: FormulaCAD-inventor_sidebar
permalink: FormulaCAD-inventor/inheriting-components.html
folder: FormulaCAD Inventor
hide_sidebar: false
comments: false
---
# Inheriting components

There are times when local parameter formulas or action packs need to be shared across components.  The component inheritance feature provides this very functionality.

To share, you would make a separate component and name it appropriately.

## Sharing Parameters

![](/images/sharing-para.jpg)

You would then call this inside a parent and check the “Inherit Parameters” check box at the top of the Add Child Screen.

![](/images/inherit-para-child.jpg)

Doing so would remove all other options such as qty, parameter override etc. When you press OK, the parameters would appear in the Inherited Parameters tab.

![](/images/sharing-component-definition.jpg)

These parameters would be treated as if they were local parameters in the context of the component which calls them.

## Sharing Action Packs

Sharing Actions packs is similar to sharing parameters. You would define a component where you would define actions packs that you intend to share. This may or may not be same as the one which contains the shared parameters.

![](/images/sharing-action-component-definition.jpg)

You would then call this as a child in a component where you would like to use these shared action packs.

![](/images/sharing-action-component-definition-child.jpg)

When you do so, the Select Action Packs tab will appear which will allow you to select which action packs you want to link from this component.

When you press OK this action pack will appear in the list of actions.

![](/images/sharing-action-component-definition-child-edit.jpg)

If you press Edit on this action pack, following dialog box is displayed

![](/images/sharing-action-component-FormulaCAD.jpg)

These action packs are treated as if they were defined in the current component.
