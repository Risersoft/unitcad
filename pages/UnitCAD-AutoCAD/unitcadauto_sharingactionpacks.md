---
title: Sharing Action Packs
keywords: Sharing Action Packs
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/sharing-action-packs.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Sharing Action Packs

Sharing Actions packs is similar to sharing parameters. You would define a component where you would define actions packs that you intend to share. This may or may not be same as the one which contains the shared parameters.

![](/images/sharing-action-comp-def.jpg)

You would then call this as a child in a component where you would like to use these shared action packs.

![](/images/sharing-action-comp-def-child.jpg)

When you do so, the Select Action Packs tab will appear which will allow you to select which action packs you want to link from this component.

When you press OK this action pack will appear in the list of actions.

![](/images/sharing-action-comp-definition.jpg)

If you press Edit on this action pack, following dialog box is displayed

![](/images/sharing-action-unitcad.png)

These action packs are treated as if they were defined in the current component.

Another thing to note is that when you export a component which has action packs from another component, you need to select the action packs again when you import it back in. UnitCAD will display a message to this effect when you import.
