
var app = angular.module("appAjax", []);
app.controller("appAjaxCtrl", function ($scope, $http) {
 
    $scope.dados = [];
    var carregaDados = function () {

        $http.get("http://localhost:55049/api/compra/RetornarTodosComprasPorUsuario", { params: { id: 1 } }).success(function (data) {
            $scope.dados = data;
        }).error(function (data) {
           alert("Erro ao obter as compras.");
        });

    };

    carregaDados();

});


//Diretiva para Input Aceitar somente números inteiros
app.directive('numbersOnly', function () {
    return {
        require: 'ngModel',
        link: function (scope, element, attr, ngModelCtrl) {
            function fromUser(text) {
                if (text) {
                    var transformedInput = text.replace(/[^0-9]/g, '');

                    if (transformedInput !== text) {
                        ngModelCtrl.$setViewValue(transformedInput);
                        ngModelCtrl.$render();
                    }
                    return transformedInput;
                }
                return undefined;
            }
            ngModelCtrl.$parsers.push(fromUser);
        }
    };
});


//Mascara de valor moeda
app.filter('moeda',
    ['$filter', function (filter) {
        return function (amount) {
            var n = amount,
            c = 2,
            d = ",",
            t = ".",
            s = n < 0 ? "-" : "",
            i = parseInt(n = Math.abs(+n || 0).toFixed(c)) + "",
            j = (j = i.length) > 3 ? j % 3 : 0;
            return 'R$ ' + s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
        }
    }]);