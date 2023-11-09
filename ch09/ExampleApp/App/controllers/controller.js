myApp.controller("dayCtrl", function ($scope, days) {
    $scope.day = days.today;
});

myApp.controller("tomorrowCtrl", function ($scope, days) {
    $scope.day = days.tomorrow;
});