---
title: Entities
keywords: Entities
sidebar: appsysdev_sidebar
permalink: appsystem-developer/entities.html
folder: AppSysDev
hide_sidebar: false
comments: false
---


# Entities

## Create

Click on AppSystem ->New->New Entity

![](images/image8_12.jpg)

>Entity Tab

User create new entity here.

**Entity**->Set Entity name in this Field.

    E.g- C

**Description Entity**->User can set description of entity here.

    E.g-Customer

**SysTable**->User can select systableid from combo

    E.g- Mainpartyid

**Product**->User can select Product for entity

**Select View Key**->User can set View for default output for created output.

    E.g-listpartyCustomer

**Select View Filter**->User can set Filter key for showing view output with filter key.

>Grid Condition Tab

User can set conditions which should be available on view’s Grid. Conditions should de define in XML format and syntax should be correct.

    E.g-<COL KEY="PartyType"><VALUE VALUE1="C"/></COL>
    PartyType-column name and C it’s value

![](images/image8_13.jpg)

>Children Tab

User can add accessibility of Systableid for other Products.

![](images/image8_14.jpg)

## List

Click on AppSystem -> Entities

![](images/image8_15.jpg)

## Edit

Click on AppSystem -> Entities->Right Click->Edit Entity

![](images/image8_16.jpg)
