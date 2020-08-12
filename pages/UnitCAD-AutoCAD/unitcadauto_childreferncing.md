---
title: Child Referencing
keywords: Child Referencing
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/child-referencing.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Child Referencing



A very important aspect of UnitCAD is that you can reference children by name. You have already seen this in the context of one component definition. More generally, you can reference a child any level deep down by following the following syntax

**“parentname\\child1name\\child2name”**

With this feature, you can design your components in a very flexible and generic manner. In fact you can use this functionality even when you are adding children.

The samples shown in this section try to demonstrate this feature. You do not have to apply actions in a higher level component – you can just as easily do it within the scope of the same component. Only thing to remember is that action is happening in the context of the component where the modified entity lies. Hence all co-ordinate systems refer to the affected component. If you use a reference entity (for example a mirroring line) which is in a different context, it will be translated into the co-ordinate system of the component being modified.
