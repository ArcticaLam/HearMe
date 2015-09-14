angular.module('myApp').controller('testController', ['$scope', 'testFactory', function ($scope, testFactory) {
    $scope.TestItems = {};
    $scope.status;

    function getAllItems() {
        testFactory.getAllTestItem()
            .success(function (data) {
                $scope.TestItems = data;
            })
            .error(function (error) {
                $scope.status = 'Error when fetch data: ' + error;
            });
    }

    getAllItems();;

}]);