---
title: Browser
keywords: Browser
sidebar: appsysdev_sidebar
permalink: appsystem-developer/browser.html
folder: AppSysDev
hide_sidebar: false
comments: false
---

# Browser

## Create

There are two options to create browser:
1.	New -> New Browser
2.	AppSystem -> Browser ->Right Click ->Copy Browser

After choosing any one option, the browser form will appear.

![](images/image8_74.jpg)

>Browser Options Tab

**Browser Key** ->User can set browser key in this block ,Entered Key should be unique for publisher and product.

    E.g. gst.Invoice

**Browser Name** ->User can set Browser Name in this block.

    E.g. Invoice

**Applications** ->User can set application name after select product in this block.

    E.g. Kasp

**Startup Node** ->User can set startup node for browser.

    E.g. ID1

**Expand Level** ->User can set expand level in this block.

    E.g. 0

**Product** ->User can select product in this block.

    E.g. ASP

>Browser Definition Tab

![](images/image8_75.jpg)

**&lt;ROOT>**->Starting Tag Browse definition.

**&lt;ID>BROWSEID&lt;/ID>** ->User can define browse ID in this block

**&lt;DISPGRID>** -> Starting Tag for grid display.

**&lt;VIEW KEY** ->starting tag for view key assign

**&lt;DISPGRID>** -> Ending Tag for grid display.

**&lt;TREE>** -> Starting Tag for Browse tree

**<_DT KEY** -> User can set sql query for data source.

**<NODE KEY** ->Starting Tag for Add Node.

**&lt;VIEW KEY**->User can assign view key in this block.

**&lt;IDX VALUE**->User can pass IDX value.

**&lt;FILTER KEY** ->User can set filter key.					

**&lt;VALUE VALUE1**->Assign filter value.				

**&lt;/FILTER>** ->Ending tag for Filter Key.

**&lt;/VIEW>** ->Ending tag for View.

**&lt;/NODE>** ->Ending tag for Node.

**&lt;/TREE>** -> Ending Tag for Browse tree.

**&lt;/ROOT>** -> Ending Tag Browse definition.

>DataXML Tab


**SysEntXML** -> _>

![](images/image8_76.jpg)

**IDSecXML** ->

![](images/image8_77.jpg)

**GridCondition** ->

![](images/image8_78.jpg)

>Children Tab

![](images/image8_79.jpg)

## List

Click on AppSystem -> Browsers

![](images/image8_80.jpg)

## Edit

Click on AppSystem -> Browsers->Edit Browser

![](images/image8_81.jpg)
