---
title: Curves
keywords: Curves
sidebar: unitcad-autocad_sidebar
permalink: unitcad-autocad/curves.html
folder: UnitCAD-AutoCAD
hide_sidebar: false
comments: false
---
# Curves    

## Line



Component Code – Line

Parameter Groups – As shown below

![](/images/line-select.jpg)  

### Line2p (2 points)

![](/images/line2p-component-def-child.jpg)

![](/images/line2p-drawing3.png)

### Linept (point+tangent)

![](/images/linept-component-def-child.jpg)

Qty has been chosen as 2 and onright1 parameter has been formulated to have different values for each instance.

TanCurve1 is a string parameter which needs to evaluate into a circular entity.

C1 is a circle centred at (0,0) and with a radius of 20.

![](/images/linept-component-def.jpg)

![](/images/linept-drawing4.jpg)

### Linepper (point+perpendicular)

![](/images/Linepper-component-def.jpg)

L2p is a previously created line.

![](/images/linepper-drawing6.jpg)

### Line2t (tangent+tangent)

TanCurve1 and TanCurve2 are string parameters which need to evaluate into circular entity.

#### Circles Not Intersecting Case 1


![](/images/cir-not-intersect-case1-component-def.jpg)

![](/images/cir-not-intersect-case1-drawing.jpg)

#### Circles Not Intersecting Case 2

If two circles don’t intersect and one circle is completely constrained inside the other, no tangent is possible.

#### Circles Intersecting at 2 Points


![](/images/cir-intersect-at-2point-component-def.jpg)

![](/images/cir-intersect-at-2point-drawing5.jpg)

#### Circles Intersecting at 1 Point Case 1


![](/images/cir-intersect-at-1point-case1-component-def.jpg)

![](/images/cir-intersect-at-1point-case1-drawing3.jpg)

#### Circles Intersecting at 1 Point Case 2


![](/images/cir-intersect-at-1point-case2-component-def.jpg)

![](/images/cir-intersect-at-1point-case2-drawing4.jpg)

### Linetper (tangent+perpendicular)


![](/images/linetper-component-def.jpg)

![](/images/linetper-drawing4.jpg)

## Polyline

Code – Pline

Parameters – Pointlist, Bulgelist, Closed

Pointlist is the list of points

Bulgelist is the list of bulges. If the bulgelist parameter contains less items than pointlist, bulge is automatically taken as 0 for the remaining vertices.

Closed – If closed is set to 1 the polyline is closed.

![](/images/polyline-component-def.jpg)

![](/images/polyline-drawing2.jpg)

![](/images/polyline-component-def-child.jpg)

![](/images/polyline-drawing3.jpg)

## Circle

Component Code – Circle

Parameter Groups – As shown below

![](/images/cir-select.jpg)

### Circle cr (centre,radius)

![](/images/circle-cr-component-def.jpg)

![](/images/circle-cr-drawing2.jpg)

### Circle ct (centre, tangent)

### Circle 2p (2 points)

![](/images/circle-2p-component-def-child.jpg)

![](/images/circle-2p-drawing4.jpg)

### Circle 2pr (2 points + Radius)


![](/images/circle-2pr-component-def-child.jpg)

![](/images/circle-2pr-drawing3.jpg)

### Circle 3p (3 points)


![](/images/circle-3p-component-def.jpg)

![](/images/circle-3p-drawing4.png)

### Circle ptr (Point  tan radius)

![](/images/circle-ptr-component-def.jpg)

![](/images/circle-ptr-drawing16.jpg)

### Circle ttr (Tan tan radius)


![](/images/circle-ttr-component-def-child.jpg)

![](/images/circle-ttr-drawing3.jpg)

### Circle ttt (Tan tan tan)

Currently not implemented.

## Ellipse (centre,majorLen,minorLen)

Component Code – Ellipse

![](/images/ellipse-component-def.jpg)

![](/images/ellipse-drawing4.jpg)


## Arc

Component Code – Arc

It is notable here that arc component is always drawn in anticlockwise direction.

Parameter Groups – As shown below

![](/images/arc-select.jpg)

### Arc 3p (3 points)


![](/images/arc3p-component-def-child.jpg)

![](/images/arc3p-drawing2.jpg)

### Arc 2pr (2 points + radius)


![](/images/arc2pr-component-def-child.jpg)

![](/images/arc2pr-drawing2.jpg)

### Arc 2pang (2 points + Angle)


![](/images/arc2pang-component-def-child.jpg)

![](/images/arc2pang-drawing7.jpg)

### Arc 2ptan (2 points + Tangent)


Point1 needs to be on the curve identified in tancurve1 parameter.

![](/images/arc2ptan-compon-def-child.jpg)

![](/images/arc2ptan-drawing2.jpg)

### Arc 2ptan (2 points + Perpendicular)



Point1 needs to be on the curve identified in perpento parameter.


![](/images/arc2ptanper-comp-def-child.jpg)

![](/images/arc2ptanper-drawing.jpg)

### Arc ttr (tancurve1, tancurve2, Radius)


![](/images/arcttr-comp-def-child.jpg)

![](/images/arcttr-drawing4.jpg)

### Arc2pc (Centre + 2 Points)


![](/images/arc2pc-comp-def-child.jpg)

![](/images/arc2pc-drawing5.jpg)

### Arc pcang (Centre + Point + Angle)

![](/images/arc-pcang-comp-def-child.jpg)

![](/images/arc-pcang-drawing7.png)

### Arc pclen (Centre + Point + Length)


![](/images/arc-pclen-comp-def-child.jpg)

![](/images/arc-pclen-drawing8.png)

## Hatch (CurveList, Gradient, Pattern)



Component Code = Hatch

Curvelist = list of curves which define a boundary.

Any one of Gradient or Pattern should be used.

Gradient = Name of any of the built in gradients in AutoCAD

Pattern = Name of any of the built in pattern in AutoCAD

![](/images/hatch-comp-def-child.jpg)

![](/images/hatch-drawing12.jpg)


## Point

Component Code = point

Creates a point in the current component block

Used to create a reference point which can be used later in the model.

## Polygon (pointlist, filletradius)


![](/images/polygon-comp-def-child.jpg)

![](/images/polygon-drawing7.jpg)


## Rectangle

Component Code = rect

Parameter Groups = As shown below

![](/images/rect-select.jpg)

Rectangle 2p (2 points), Rectangle plw (point + length + width)

![](/images/rect-comp-def-child.jpg)

![](/images/rect-drawing8.png)

## SplineCurve (pointlist)

Component code - Spline

![](/images/spline-comp-def-child.png)

![](/images/spline-drawing8.png)

## OffsetCurve (Ent1,Offset)

Component Code = OffsetCurve

![](/images/offsetcurve-com-def-child.jpg)

![](/images/offsetcurve-drawing10.jpg)
