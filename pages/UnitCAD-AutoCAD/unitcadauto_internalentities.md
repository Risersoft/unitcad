---
title: Internal Entities
keywords: Internal Entities
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/internal-entities.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Internal Entities



Internal entities are special UnitCAD components that can be used to create geometry (and annotation). These are directly drawn as “entity” into the current component definition block.

This functionality can be used to create new geometry from scratch or add geometry to an existing AutoCAD block. UnitCAD places almost the entire functionality of geometry creation in AutoCAD with this feature.

Choosing whether to have an AutoCAD parametric block or to create within UnitCAD using internal entities is generally a matter of chioice and organization. Sometimes geometry is more suited to be created as a parametric block. On the other hand, if it is too dynamic, a block may get unnecessarily complex. As a guideline, focus should be on easy maintenance in future.

Internal entities are called as “normal” children with parameters override. Some of the entities have only one set of parameters and hence “Copy From Child” will just copy the entire set of parameters. In many of these entities, there are multiple variants to choose from as in the user interface of AutoCAD.  In this case parameter groups have been defined inside UnitCAD and so when you press “Copy From Child”, you will be presented with a list of variants to choose from. UnitCAD determines what variant to draw based on the presence or absence of the appropriate parameters – this will help if you add the overriding parameters manually.

In the following sections, it is shown what variants are available. For each variant, some sample values and their resulting CAD output is shown. There might be several possible options inside each variant. In that case, multiple qty has been taken and CAD output contains all such options. AutoCAD background color has been converted to White for the purpose of capturing screenshots to enable easy viewing and printing.


