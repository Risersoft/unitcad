---
title: Terminology
keywords: Terminology
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/terminology.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Terminology



**• Work Order



Each new job is known as a work order. You would enter or import global parameter values for a workorder and select a top level component to build. UnitCAD would then traverse the hierarchy of the components, calculate their local and parent parameters and produce CAD output.



**• Global Parameters



These are top level parameters for which values are entered or imported for a work order. Generally you would have some components which relate these top level values to geometrical output or to the local parameters of child components.



**• Component Definition

    o  Components are the basic unit of geometry and annotation creation inside UnitCAD.



       § You can link it to an AutoCAD parametric block in which you need to map block parameters to component parameters.



       § You can “call” child components such as line, circle, arc, text etc to create geometry and annotation from scratch linked to component parameters.



       § These components can call other child components or be themselves called from some other component.Thus you can build highly reusable collection of components.


    o  Local Parameters

       § Local parameters are parameters defined in the scope of the component definition. These parameters are generally of two types:



**• Fixed values meant to be set by the calling parent



**• Formulas taking into account fixed values or global parameters which are mapped to AutoCAD parametric block or child component parameters or both

    o  Child Components

Each component can call other components as children and override their parameters with its own parameters or global parameters. Of course this means the component can itself be called by other components.



Geometry like line, arc, circle etc. and annotation like text, dimension, leader etc have  also been defined as components inside UnitCAD enabling a consistent design.



    o  Actions

Each component also defines a set of actions such as move, rotate etc. These are used to modify the geometry contained inside the component.

UnitCAD follows a naming mechanism to allow geometry to be precisely picked up for execution of these actions.



**• Design Table



Design tables are basically collections of data. In any drawing office, typically you have a lot of data picked up from data tables to be used inside a CAD model.



UnitCAD provides such a functionality built-in, which allows creation of new data tables and maintenance of data inside them.



This data can then be “looked up” inside component formulas reducing the need for entering standard data.
