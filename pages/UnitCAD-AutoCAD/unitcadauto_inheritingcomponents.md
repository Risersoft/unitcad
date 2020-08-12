---
title: Inheriting Components
keywords: Inheriting Components
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/inheriting-components.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Inheriting Components

There are times when local parameter formulas or action packs need to be shared across components.  The component inheritance feature provides this very functionality.

To share, you would make a separate component and name it appropriately.

## Sharing Parameters

![](/images/sharing-para-comp-def.jpg)

You would then call this inside a parent and check the “Inherit Parameters” check box at the top of the Add Child Screen.

![](/images/sharing-para-comp-def-child.jpg)

Doing so would remove all other options such as qty, parameter override etc. When you press OK, the parameters would appear in the Inherited Parameters tab.

![](/images/sharing-para-comp-definition.jpg)

These parameters would be treated as if they were local parameters in the context of the component which calls them.

## Sharing Action Packs

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
