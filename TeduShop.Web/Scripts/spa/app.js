/// <reference path="../../bower_components/angular/angular.js" />

var myApp = angular.module('myModule', []);

myController.$inject = ['$scope'];

myApp.controller('myController', myController);

myApp.controller('mySecondController', function ($scope) {
    $scope.message = "This message comes from mySecondController";
});

function myController($scope) {
    $scope.message = "This message comes from myController";
}