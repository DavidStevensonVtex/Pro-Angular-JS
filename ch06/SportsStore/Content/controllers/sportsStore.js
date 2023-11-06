angular.module("sportsStore")
	.constant("dataUrl", "Http://localhost:5500/products")
	.controller("sportsStoreCtrl", function ($scope, $http, dataUrl) {
		$scope.data = {};

		$http.get(dataUrl)
			.success(function (data) {
				console.log("data", data);
				$scope.data.products = data;
			})
			.error(function (error) {
				$scope.data.error = error;
			});
	});