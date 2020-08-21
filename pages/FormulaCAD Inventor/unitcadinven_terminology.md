---
title: Terminology
keywords: Terminology
sidebar: FormulaCAD-inventor_sidebar
permalink: FormulaCAD-inventor/terminology.html
folder: FormulaCAD Inventor
hide_sidebar: false
comments: false
---
# Terminology

**•** Work Order

Each new job is known as a work order. You would enter or import global parameter values for a work order and select a top level component to build. FormulaCAD would then traverse the hierarchy of the components, calculate their local and parent parameters and produce CAD output.

**•** Global Parameters

These are top level parameters for which values are entered or imported for a work order. Generally you would have some components which relate these top level values to geometrical output or to the local parameters of child components.

**•** Component Definition

   o  Components are the basic unit of geometry and annotation creation inside FormulaCAD.

      § You can link it to an inventor part or assembly in which you need to map block parameters to component parameters.  FormulaCAD traverses through the entire hierarchy and generates a parameter list which are then mapped to FormulaCAD parameters.

      § These components can call other child components or be themselves called from some other component. Thus you can build highly reusable collection of components.

   o  Local Parameters

      § Local parameters are parameters defined in the scope of the component definition. These parameters are generally of two types:

**•** Fixed values meant to be set by the calling parent

**•** Formulas taking into account fixed values or global parameters which are mapped to Inventor file parameters or child component parameters or both

   o  Child Components

      Each component can call other components as children and override their parameters with its own parameters or global parameters. Of course this means the component can itself be called by other components.

   o  Actions

      Each component also defines a set of actions to make constraints. Mate, Flush, Angle, Insert constraints are available. FormulaCAD follows a naming mechanism to allow geometry to be precisely picked up for execution of these actions.

**•** Design Table

Design tables are basically collections of data. In any drawing office, typically you have a lot of data picked up from data tables to be used inside a CAD model.

FormulaCAD provides such a functionality built-in, which allows creation of new data tables and maintenance of data inside them.

This data can then be “looked up” inside component formulas reducing the need for entering standard data.
