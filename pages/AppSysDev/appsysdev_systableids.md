---
title: Systable ID's
keywords: Systable ID's
sidebar: appsysdev_sidebar
permalink: appsystem-developer/systableids.html
folder: AppSysDev
hide_sidebar: false
comments: false
---


# Systable ID’s

## Create

Click on New->New Sys Table

![](images/image8_8.jpg)

>SysTable Tab

**Sortindex**->User can set an integer value for sortindex.

**Applications**->User can set application code here, if not set any value then it’s systableid accessible for all apps of selected Product.

**ID Field**->User can set key field here it’s unique with Publisher & Product.

    E.g. InvoiceID

**Table Name**->User can set Table name of Key Field.

    E.g. Invoice

**Descrip ID**->User can Display Name of Key Field.

    E.g. Invoice

**Product**->User can select Product for which Systableid is created.

**DataXML**->User can set check condition in this section.

    E.g. <CHECK/>

**Select View Key**->User can set View key for default View Output.

**Select View Filter** -> User can set Filter key which apply on default view Output for created systableid.

>Children Tab

User can add accessibility of Systableid for other Product.

![](images/image8_9.jpg)

**Product**->User can set Products for accessibility of systableid.

**AppList**->User can set applist here.

**Permission List**->User can assign permisionkey which is defined in application menu definition.

## List

Click on AppSystem -> Systable ID’s

![](images/image8_10.jpg)

## Edit

Click on AppSystem -> SystableID’s->Right Click->Edit SysTable

![](images/image8_11.jpg)
