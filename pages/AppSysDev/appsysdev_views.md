---
title: Views
keywords: Views
sidebar: appsysdev_sidebar
permalink: appsysdev_views.html
folder: AppSysDev
hide_sidebar: false
comments: false
---

# Views

## Create

There are two options to create views:
1. New -> New View
2. AppSystem -> Views->Right Click ->Copy View..

After choosing any one option, the View form will appear.

![](images/image8_17.jpg)

**Product** -> Firstly select product in which views to be created.

    E.g- ASP

![](images/image8_18.jpg)

**Applications** ->  After select product than select applications.

    E.g-Kasp

![](images/image8_19.png)

**View Key** ->User can assign view key it is should be unique for Publisher and Product

    E.g-listInvoice

**StrView** ->User can set display name for view.

    E.g-Invoice

**Visualizations** ->User can select grid visualization for View output.

![](images/image8_20.png)

**Grid**->

![](images/image8_21.png)

**Chart**->

![](images/image8_22.png)

**Dash**->

![](images/image8_23.png)

**HTML**->

![](images/image8_24.jpg)

**Visualization Small** -> User can select grid visualization small for Mobile’s View output.

![](images/image8_25.png)

**Grid**->                          **Chart**->

![](images/image8_26.jpg)




**Dash**->     **List**->                   

![](images/image8_27.jpg)



**Permission Key**-> User can set permission keys for created view.

    E.g-ID_SaleInvoices

![](images/image8_28.png)

Default value is zero.

>DataSource Tab

User can set data source SQL for view output in this section.

![](images/image8_29.jpg)

**AppliFilters** ->User can set list of filters which are applicable on this view.

    E.g- Comp,Campus ..etc
![](images/image8_30.jpg)

**Type** ->User can set Data source query type Default value is Fields but user can it to Template as per requirement.

![](images/image8_31.jpg)

**View Width Percent** ->User can set view’s output percentage.

    E.g-140.00

**Ignore Paging** ->Default value for this is False but user can set True if paging require on view output.

![](images/image8_32.jpg)

**Fields Tab** ->

![](images/image8_33.jpg)

**Select**-> User can set fields of Data source Query without select and Form keywords.

![](images/image8_34.jpg)

**From**-> User can set Data Source Tables or Functions.

![](images/image8_35.png)

**Client**-> User can use Client if DataSoursce is PDCClientView

![](images/image8_36.png)

**Group By**-> User can set Group by Fields of select query.

![](images/image8_37.jpg)

**Having**-> If SQL query included Having Condition then user can set having condition in this section.

![](images/image8_38.png)

**Order BY**-> User can set Order columns in this section.

![](images/image8_39.png)

**Fixed Where**-> User can set fixed where conditions in this section.

![](images/image8_40.jpg)

**ObjPermission**-> User can set Object which must be present in that Product.

>Generate->User can verify output of views after entered SQL query go to Grid available after Common tab then clicking on Generate Button and showing output.

![](images/image8_41.jpg)

**Parameters Tab** ->

![](images/image8_42.jpg)

**FiltParam**-> User can set fixed filter with default value in this block.

**Note**: FiltParam should be in XML Code and use correct Syntax. If syntax not correct then errors showing in Errors block and applied Filters should be present in AppliFilters List.

    E.g.

![](images/image8_43.png)

**&lt;FILTER>** ->Starting Tag.

**FILTER KEY**->Set Filter key define in Table ClientFilter

**ACTION**->Set Default

**VALUE VALUE1**->Set IdField like FinyearID.Function Currfinid pick current finyearid.

**OPERTYPE**->Set operation type like eq for Equal.

**&lt;/FILTER>** ->Ending Tag.

**Output**->

![](images/image8_44.jpg)

**WhereParam** ->User can create Owen where conditions as per requirement and apply particular on menu’s in menu definition.

![](images/image8_45.png)

    E.g. Use WhereParam conditions in MenuDefination

![](images/image8_46.jpg)

**TransformBefore**-> TransformBefore worked before view output generated.

![](images/image8_47.jpg)

    E.g. View Output before transformation.

![](images/image8_48.png)

![](images/image8_49.jpg)

TARGET=0

**IDFIELD**->Assigned key field. Like Returnperiod

**PIVOT**->Assigned field to transform as header. Like SectionName

**AGGCOL**->Assigned field to transform below header respective SectionName. Like Amount

_View Output after transformation_:

![](images/image8_50.jpg)

**TransformAfter**-> TransformAfter worked after view output generate.

_View Output before transformation_ ->

![](images/image8_51.jpg)

**ADDCOL** ->Column name which is to be added.

**KEY**->Assigned Caption name for added Field like perInc

**FORMULA**->Set value for Added column.

![](images/image8_52.jpg)

_View Output after transformation_ ->

![](images/image8_53.jpg)

>Common Tab

**ConditionXML**->

User can set print layout as per view output known as MMR.it is define in XML and follow below syntax.

![](images/image8_54.jpg)

**FormatXML** -> User can format of columns of visible column like Caption, Date format etc.

![](images/image8_55.png)

**Output**:

![](images/image8_56.jpg)

**Print**->

![](images/image8_57.jpg)

**Print Vertical Grid Lines** ->Default value is null.

**Max Font Size** ->User can set font size of printing output.

**Filter for Printing** ->User can set filter which apply only when printing output.

**Hide Columns**->User cat set columns which are not require for printing.

**MMRXML**->User can define format for printing known as MMRXML.

    E.g.

![](images/image8_58.jpg)

**&lt;MMR>**->Starting Tag

**SERIAL** ->Set true if require serial number on MMR output.

**DETAILHTFACT **->Set row height for MMR output.

**HEADER PREFIX **->Set Header of MMR output.

**EVAL** ->Set Evaluate value like date

**FORMAT**->Set for mat of evaluate value.

**GROUP FIELD** ->Set Field name on which output should be group by.

**TYPE**->Set type of group by

**&lt;/MMR>** ->Ending Tag.

**Output**:

![](images/image8_59.jpg)

>Grid Tab

**Complex** -> User can link multiple views through a key field in this section.

![](images/image8_60.jpg)

**&lt;DISPGRID>** ->Starting tag

**&lt;/DISPGRID>** -> Ending tag

**&lt;MAINGRID>** ->Starting tag

**VIEW KEY** -> User can set view for display grid

**&lt;MAINGRID>** -> Ending tag

**&lt;MAKEREL INSERTAT** ->set default value 0.

 **BANDS** ->User can combine all child’s view in this section.

 **FIELD** ->Set idfield

 **CHILD** ->Set child using give value 1,2 etc.

![](images/image8_61.jpg)

**Layout**-> User can define view layout in this section.

![](images/image8_62.jpg)

**Inverted View**->User can marked if require visibility of columns horizontally.

**Ban Sort**->User can marked in require sorting on view.

**Reverse Direction**-> User can marked if require visibility of columns from Ending.

**Column Headers**->User marked if require fixed header.

**Fix Columns**-User can set fixed no of columns in this block.

**strWidth**->User can width for visible fields in this block.

**Heading Factor**->User can set width for header in this block.

**strBand**->User can set Display name for view.

**Row Height Factor**->user can set row height in this block.

**GroupOn**->User can set Group column Name in this block.

**Default Wid Fact.**->User can set default value of column’s width.

**Allow Group By**->User can marked if allow group by on header columns.

**Sort On Columns**->User can set columns require sorting on columns.

**Summary**->User can define summary totals for views in this block

![](images/image8_63.jpg)

**Output** ->

![](images/image8_64.jpg)

>Chart Tab

**ChartXML**->

![](images/image8_65.jpg)

>Dashboard Tab

**HTML**->

![](images/image8_66.jpg)

**DashBoardXML**->

![](images/image8_67.png)

>Totals Tab

**TotalsXML**->

![](images/image8_68.jpg)

**Output** ->

![](images/image8_69.jpg)

>List Tab

User can define mobile views output in this block.

![](images/image8_70.jpg)

>Children Tab


![](images/image8_71.jpg)

## List

Click on AppSystem -> Applications->Views

![](images/image8_72.jpg)


## Edit

Click on AppSystem -> Applications->Right Click->Edit In View Designer

![](images/image8_73.jpg)
