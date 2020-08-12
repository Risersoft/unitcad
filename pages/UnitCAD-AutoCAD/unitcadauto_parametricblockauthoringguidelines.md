---
title: Parametric Block Authoring Guidelines
keywords: Parametric Block Authoring Guidelines
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/parametric-block-authoring-guidelines.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Parametric Block Authoring Guidelines

Good robust parametric blocks that behave in the desired manner lead to good robust UnitCAD models that behave in the desired manner. When these blocks are linked into UnitCAD components, UnitCAD creates the model tree and calls these blocks and updates the parameters. After that, how the block behaves with the new set of parameters really depends on how well the block has been made and tested.

Hence a good way is to actually test the block when it is made, supplying all sorts of possible values that can be expected and ensuring that the behavior is in line.

One often overlooked aspect is the use of the “Fix” constraint. When authoring parametric blocks, it is always a good idea to fix the origin geometry and then build other geometry around it. This ensures that the origin is not shifted when parameters change.

When an AutoCAD parametric block is linked to UnitCAD component, the origin of the block is taken to be the origin of the component and all child components are placed with respect to this origin. Hence you got to know your blocks !
