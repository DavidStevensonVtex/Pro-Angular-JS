angular.module("sportsStore")
	.controller("cartSummaryController", function ($scope, cart) {

		$scope.cartData = cart.getProducts();

		$scope.total = function () {
			let total = 0;
			for (cartItem in $scope.cartData) {
				total += (cartItem.price * cartItem.count)
			}
			return total;
		}

		$scope.remove = function (id) {
			cart.removeProduct(id);
		}
	});