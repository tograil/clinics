(function () {
    'use strict';

    var app = angular.module('clinics', ['ngAnimate', 'ngTouch']);

    app.controller('PhotoGallery', ['$http','$scope', function ($http, $scope) {
        // Set of Photos
        $scope.photos = [];
            
        $http.post('/Requests/GetGalleryImages').success(function (data) {
            $scope.photos = data;
        });
        // initial image index
        $scope._Index = 0;

        // if a current image is the same as requested image
        $scope.isActive = function (index) {
            return $scope._Index === index;
        };

        // show prev image
        $scope.showPrev = function () {
            $scope._Index = ($scope._Index > 0) ? --$scope._Index : $scope.photos.length - 1;
        };

        // show next image
        $scope.showNext = function () {
            $scope._Index = ($scope._Index < $scope.photos.length - 1) ? ++$scope._Index : 0;
        };

        // show a certain image
        $scope.showPhoto = function (index) {
            $scope._Index = index;
        };
    }]);

    app.controller('Prices', ['$http', '$scope', function ($http, $scope) {
        $scope.tab = 1;

        $scope.therapy = [];
        $scope.paradontology = [];
        $scope.ortopia = [];

        $http.post('/Requests/GetServices?type=1').success(function (data) {
            $scope.therapy = data;
        });

        $http.post('/Requests/GetServices?type=2').success(function (data) {
            $scope.paradontology = data;
        });

        $http.post('/Requests/GetServices?type=3').success(function (data) {
            $scope.ortopia = data;
        });

        $scope.isActive = function (index) {
            return $scope.tab === index;
        };

        $scope.showTab = function (index) {
            $scope.tab = index;
        };
    }]);

})();