---
title: Lights Camera Action!
keywords: Lights Camera Action!
sidebar: unitcad-inventor_sidebar
permalink: unitcad-inventor/light-camera-action.html
folder: UnitCAD Inventor
hide_sidebar: false
comments: false
---
# Lights Camera Action!



Actions allow you to define constraints, much like the “constrain” command in the Inventor user interface.

You add actions in “Action Packs” which can be used to group similar actions. You can also write a formula to conditionally apply an action pack.

![](/images/light-camera-action.jpg)

This formula needs to be a value greater than 0 for the action pack to be applied.

Other thing to note is that action packs are applied in the sequence in which they are entered. Inside an action pack, actions are applied in the sequence in which they are entered.

Inside each action, all parameters including the action code are formulas so that you can apply them conditionally. You can use the quantity formulas to have action applied multiple times and then vary some parameter using the “Choose([//index] ….)” construct.


