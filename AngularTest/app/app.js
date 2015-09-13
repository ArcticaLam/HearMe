'use strict';
var app = angular.module('myApp', ['ngRoute']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
		.when('/', {
		    templateUrl: 'views/home.html',
		    controller: 'homeController'
		})
        .when('/about', {
            templateUrl: 'views/about.html',
            controller: 'homeController'
        })
        .when('/contact', {
            templateUrl: 'views/contact.html',
            controller: 'homeController'
        })
		.otherwise({ redirectTo: '/' });

}]);

