let app = angular.module("exampleApp", []);

app.controller("topLevelCtrl", function ($scope) {
	$scope.data = {
		dataValue: "Hello, Adam"
	};

	$scope.reverseText = function () {
		$scope.data.dataValue = $scope.data.dataValue.split("").reverse().join("");
	}

	$scope.changeCase = function () {
		console.log("topLevelCtrl", "changeCase");
		let result = [];
		angular.forEach($scope.data.dataValue.split(""), function (char, index) {
			result.push(index % 2 == 1 ? char.toString().toUpperCase() : char.toString().toLowerCase());
		});

		$scope.data.dataValue = result.join("");
	}
});

app.controller("firstChildCtrl", function ($scope) {
	$scope.changeCase = function () {
		console.log("firstChildCtrl", "changeCase");
		$scope.data.dataValue = $scope.data.dataValue.toUpperCase();
	}
});

app.controller("secondChildCtrl", function ($scope) {
	$scope.changeCase = function () {
		console.log("secondChildCtrl", "changeCase");
		$scope.data.dataValue = $scope.data.dataValue.toLowerCase();
	}

	$scope.shiftFour = function () {
		let result = [];
		angular.forEach($scope.data.dataValue.split(""), function (char, index) {
			result.push(index < 4 ? char.toUpperCase() : char);
		});

		$scope.data.dataValue = result.join("");
	}
});