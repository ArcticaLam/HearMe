var app = angular.module('myApp', []);

app.controller('homeController', function ($scope, $log) {

    $log.log('Hello');
    $log.info('This is some info');
    $log.warn('warning!!');
    $log.debug('debug error');
    $log.error('ERRORRRR!!!');

});



