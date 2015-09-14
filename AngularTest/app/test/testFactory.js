angular.module('myApp').factory('testFactory', ['$http', function ($http) {
    var baseUrl = 'api/test';
    var dataFactory = {};

    dataFactory.getAllTestItem = function() {
        return $http.get(baseUrl);
    };

    return dataFactory;
}]);