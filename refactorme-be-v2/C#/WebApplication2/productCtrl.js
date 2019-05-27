(function () {
    'use strict';

    angular.module('app').controller('productCtrl', productCtrl);

    productCtrl.$inject = ['$scope', '$http',  '$filter'];

    function productCtrl($scope, $http, $filter) {

        $scope.arrProducts = new Array;
       // $scope.currency.name = "NZD";
        $scope.currency = {
            name: 'NZD'
        };

        $scope.ProductList = {
            columnDefs: [
                { field: 'Name', displayname: 'Name' },
                { field: 'Price', displayname: 'Price' },   
                { field: 'Type', displayname: 'Type' }
            ]
        };

        getProducts();             

        $scope.change = function (s) {
            $scope.currency.name = s;
            $scope.arrProducts = [];
            getProducts();
         };
       

        function getProducts() {
            $http({
                url: "Product/getProducts",
                dataType: 'json',
                method: 'GET',
                data: '',
                headers: {
                    "Content-Type": "application/json"
                }
            }).success(function (data) {
                populateGridData(data);
            }).error(function (error) {
                alert(error);
            });
        }

        function populateGridData(data) {
            var i = 0;
            angular.forEach(data, function () {
                var currencyVal = $scope.currency.name === 'EURO' ? data[i].Price * 0.67 : $scope.currency.name === 'USD' ? data[i].Price * 0.76 : data[i].Price;
                var currencySymb = $scope.currency.name === 'EURO' ? '€' : '$';
                var p = {
                    Name: data[i].Name,
                    Price: $filter('currency')(currencyVal, currencySymb, 2),
                    Type: data[i].Type
                };

                $scope.arrProducts.push(p);
                i += 1;
            }
            );

        }

        $scope.ProductList = { data: 'arrProducts' };
    }

   
   
})();