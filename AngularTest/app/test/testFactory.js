﻿angular.module('myApp').factory('testFactory', ['$http', function ($http) {
    
    var baseUrl = 'localhost:1609/api/test';
    var dataFactory = {};

    dataFactory.getAllTestItem = function() {
        return $http.get(baseUrl);
    };

    return dataFactory;
}]);