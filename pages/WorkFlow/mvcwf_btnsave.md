---
title: BtnSave
keywords: BtnSave
sidebar: mvcwf_sidebar
permalink: web-development-workflow/btnsave.html
folder: Workflow
hide_sidebar: false
comments: false
---





#  btnsave

This method is called when we click on save button. This method first checks for client side model validation. After successfully validating model the data object is posted to the server.

```


$scope.btnsave = function (maintainData) {
    //debugger;
    $scope.result = '';
    $scope.status = 'submitted';
    if ($scope.userform.$invalid) {
        return;
    }

    $scope.calculatemodel();
    var datamodel = {};
    angular.copy($scope.model, datamodel);
    datamodel.dsCombo = null;
    $scope.cleanupmodel(datamodel);
    var token = $('input[name="__RequestVerificationToken"]').val();
    var payload = { data: JSON.stringify(datamodel), __RequestVerificationToken: token }
    var base = window.location.href;
    $scope.status = 'posted';

    $.post(base, payload, function (result) {
        $scope.status = 'loaded';
        if (result.success) {
            //debugger;
            if (maintainData == undefined) {
                var data = JSON.parse(result.data);
                loadmodel(data);
            }
            $scope.result = 'success';
            $scope.message = '';

            if (maintainData) {
                $scope.isNextQues = true;
                return $scope.isNextQues;
            }
        }
        else {
            if (result.message === '') { result.message = 'Unknown Error!' };
            $scope.result = 'failure';
            $scope.message = result.message;
        }
        $scope.$apply();
        return;
    });
};

```

