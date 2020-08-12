---
title: Lights Camera Action!
keywords: Lights Camera Action!
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/light-camera-action.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Lights Camera Action!

Actions allow you to do stuff with existing geometry in the model, much like the “Modify” menu in the AutoCAD user interface. This is sometimes necessary for easy geometry creation (for example the mirror action) or for modifying a standard component definition when you are calling it in a different context.

You add actions in “Action Packs” which can be used to group similar actions. You can also write a formula to conditionally apply an action pack.

![](/images/light-caemra-action-com-def-actionpack.jpg)

This formula needs to be a value greater than 0 for the action pack to be applied.

Other thing to note is that action packs are applied in the sequence in which they are entered. Inside an action pack, actions are applied in the sequence in which they are entered.

Inside each action, all parameters including the action code are formulas so that you can apply them conditionally. You can use the quantity formulas to have action applied multiple times and then vary some parameter using the “Choose([//index] ….)” construct.


