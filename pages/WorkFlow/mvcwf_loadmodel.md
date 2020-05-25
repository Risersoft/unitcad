---
title: Loadmodel
keywords: Loadmodel
sidebar: mvcwf_sidebar
permalink: web-development-workflow/loadmodel.html
folder: Workflow
hide_sidebar: false
comments: false
---



# Loadmodel

Loadmodel is a function inside angular controller which binds data to their respective model and stores that data in an object .
Data binding is done through ng-model which provides two way data binding.

```
if (!$scope.InvoiceInfo.GSTInvoiceTypeSelected)   {
         $scope.InvoiceInfo.GSTInvoiceTypeSelected = {};
    }
 if ($scope.OrgInvoice) {
         $scope.typchange($scope.InvoiceInfo.GSTInvoiceTypeSelected);
    }
$scope.partyfn = function (code) {
    $scope.SelectedParty = $.grep($scope.dsCombo.Customer, function    (item, index) { return item.CustomerID === code.CustomerID })[0];
    $scope.InvoiceInfo.CTIN = $scope.SelectedParty.GSTIN;
            };

            $scope.partycampfn = function (coden) {
                var url = '/frmGstInvoiceSale/IDOutput' + location.search;
                var payloaddata = { key: 'division', ID: coden };
                $.post(url, payloaddata, function (result) {                  
                    if (result.success) {                        
                        if (result.Data) {                           
                             $scope.DivisionList = result.Data.Data.Table;
                            $scope.dsCombo.Division = $scope.DivisionList;                                       
                        };
                    }
                    $scope.$apply();
                    return;
                });             

            }
            if ($scope.InvoiceInfo.CustomerIDSelected) {
                $scope.partyfn($scope.InvoiceInfo.CustomerIDSelected);
            }
            $scope.partycampfn($scope.InvoiceInfo.CampusID);

        };
        loadmodel($scope.model);

```

