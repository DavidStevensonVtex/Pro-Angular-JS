angular.module("cart", [])
	.factory("cart", function () {
		let cartData = [];

		return {
			addProduct: function (id, name, price) {
				let addedToExistingItem = false;
				for (item of cartData) {
					if (item.id == id) {
						item.count++; addedToExistingItem = true;
						break;
					}
				}

				if (!addedToExistingITem) {
					cartData.push({ count: 1, id: id, price: price, name: name });
				}
			},

			removeProduct: function (id) {
				for (let i = 0; i < cartData.length; i++) {
					if (cartData[i].id == id) {
						cartData.splice(i, 1);		// splice(start, deleteCount)
						break;
					}
				}
			},

			getProducts: function () {
				return cartData;
			}
		}
	});