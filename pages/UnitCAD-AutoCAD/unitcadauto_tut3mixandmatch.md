---
title: Tutorial 3 - Mix and Match (Children, Actions)
keywords: Tutorial 3 - Mix and Match (Children, Actions)
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/tutorial3-mix-and-match.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Tutorial 3 - Mix and Match (Children, Actions)



Select “File / Parent Component definition” from the New Menu and make entries as follows

![](/images/tut3-component-def.jpg)


In the Local Parameters Tab, click on Add. Make entries as follows:

![](/images/tut3-component-def-para.jpg)

Press OK.

Go to the children tab. Click Add.

Make entries as follows:


![](/images/tut3-component-def-child.jpg)


Go to the Parameters Value / Override button. Click on “Add” button and select “iPoint” from the parameter list. Enter formula and press OK such that the resulting screen looks like following:

![](/images/tut3-component-def-child-add.jpg)

Press OK and get back to the “Children” Tab.

Press “Add” again and make entries as follows:


![](/images/tut3-component-def-child-add-again.jpg)


Go to the Parameters Value / Override button. Click on “Add” button and select “iPoint” from the parameter list. Enter formula and press OK such that the resulting screen looks like following:

![](/images/tut3-component-def-para-value.jpg)

The formula is point([//dist], [//dist])

Press OK and get back to the children tab.

Now go to the Actions tab and click Add. Make Entries as follows:

![](/images/component-definition-action-pack.jpg)

Click on “Add”, make entries and press OK such that the resulting screen looks like the following

Press OK to come back to component definition screen.

Now press “Test Component”

CAD Maker window appears

![](/images/cad-maker3.png)

In the background, a new AutoCAD drawing has been made.

![](/images/drawing4.jpg)

Notice that demo-qs1 block (tie-rod) is inserted at (0,0). Demo-qs2 is inserted at (100,100) which is the value of the “dist” parameter. The Circle Center and line origin do not coincide because we used the move action to move the center up by a distance of 100.
