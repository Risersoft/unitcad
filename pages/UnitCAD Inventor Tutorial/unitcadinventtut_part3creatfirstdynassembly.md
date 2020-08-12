---
title: Part#3 – Creating your First Dynamic Assembly
keywords: Part#3 – Creating your First Dynamic Assembly
sidebar: unitcad-inventor-tutorial_sidebar
permalink: unitcad-inventor-tutorial/Part3-creating-your-first-dynamic-assembly.html
folder: UnitCAD Inventor Tutorial
hide_sidebar: false
comments: false
---


# Part #3 – Creating your First Dynamic Assembly


Now we have in place the child component definitions which can be called dynamically in a parent level component definition.

The first two components that we just created are the ones that are supplied in UnitCAD by default as follows:

| Valve-qs | Valve-qs|
|:---------|:--------|
|Pipeflange-qs|Pipeandflange|

For our dynamic assembly we will use the already existing definition rather than creating a new one. Once you understand the concepts, you can go ahead and create new definitions. So let us edit the PipeAssembly component definition in the List Component Definitions screen to open up the following screen:

![](/images/part3-component-defi.jpg)

Go to the children tab:

![](/images/goto-children-tab-comp-defi.jpg)

Both child definitions have been called in this definition. Edit the pipeandflange child to open up following:

![](/images/component-defi-child1.jpg)

Notice that quantity has been given a formula [//npipe]. PipeAssembly component definition needs to make sure that a parameter with the name npipe exists and is calculated appropriately.

Now open up the Valve-80NB child to open up the following screen:

![](/images/component-defi-child2.jpg)

Again we see that the valve has been assigned a quantity formula.

Let us now revisit the parameters screen:

![](/images/parameter-screen.jpg)

We can see that in this screen, parameter names and formulas have been defined.

Let us analyze each parameter:

|Name |Used by |Remark|
|:----|:-------|:-----|
TotLen|PipeL, Npipe|TL1 is the global parameter set by user in the work order data.
ValveReq|PipeL|VR is the global parameter set by user in the work order data
Valvelen|PipeL, Npipe|Depending on whether valve is required or not, we derive the length eaten up by the valve. This is required to calculated the pipe length
Npipe|This is the parameter given in the quantity field of the PipeandFlange child.|We can see that the formula ensures that individual pipe cannot be more than 500 long
PipeL|Remember from the Part#2 that this parameter is used by the PipeAndFlange assembly|The formula takes care whether valve Is present or not. Individual pipe length is set such that the total length is equal to specified.|

Above is sufficient to bring all parts and assemblies into the context. Next we need to see how constraints are applied. Goto the Action Packs tab:

![](/images/part3-component-defi2.jpg)

Edit the pipe assembly action pack and go to actions tab.

![](/images/component-defi-action-pack.jpg)

As we can see here, UnitCAD applies Insert constraints based on the actions defined here. Let us see the salient points here:

1.  Each action is applied n no. of times, where n is the qty column. During each action instance, index parameter is incremented so that we can choose appropriate part and entity using this parameter.

2.  We can walk down the assembly hierarchy using the \\ separator in Partformula. We can choose a particular instance of the assembly using the “: n” construct, where n is the index number of the instance.

3.  All fields are formulas where functions and all parameters in context can be used.

Now we are in a position to run this sample. You can select “Test Component” from this screen to make this dynamic component. You can also go to the work order CAD maker screen to change the global parameters and see the effects.

![](/images/test-component.jpg)
