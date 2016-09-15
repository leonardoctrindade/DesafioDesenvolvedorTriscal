var app = angular.module("appDesafioDesenvolvedor", []);

app.controller("appDesafioDesenvolvedorNovaCompraCtrl", function ($scope, $http, $filter) {

    //*****************************DROPDOWNLIST CARREGANDO PRODUTOS***************************************

    //Método para popular o dropdown de categorias
    $scope.dadosCategoria = [];
    var CarregaDadosCategoria = function () {

        $http.get("http://localhost:55049/api/categoria/RetornarTodasCategorias").success(function (data) {
            $scope.dadosCategoria = data;
        }).error(function (data) {
            alert("Erro ao obter as categorias.");
        });


    };

    //Carrega o dropdown de subcategoria através do id selecionado da categoria
    $scope.dadosSubCategoria = [];
    $scope.CarregaDadosSubCategoria = function () {
        if ($scope.categoria) {
            $http.get(
                "http://localhost:55049/api/subCategoia/RetornaSubCategoiaPorCategoria",
                    { params: { id: $scope.categoria } }
            ).success(function (data) {
                $scope.dadosSubCategoria = data;
            }).error(function (data) {
                alert("Erro ao obter as subcategorias.");
            });
        } else {
            $scope.dadosSubCategoria = [];
        }

    };

    //Popula os produtos no dropdown de categoria
    $scope.dadosProdutos = [];
    $scope.CarregaDadosProdutosCategoria = function () {
        $http.get(
            "http://localhost:55049/api/produto/RetornarProdutosPorCategoria",
                { params: { id: $scope.categoria } }
        ).success(function (data) {
            $scope.dadosProdutos = data;
        }).error(function (data) {
            alert("Erro ao carregar os produtos.");
        });
    };

    //Popula os produtos no dropdown de subcategoria
    $scope.CarregaDadosProdutosSubCategoria = function () {
        $http.get(
             "http://localhost:55049/api/produto/RetornaProdutoPorSubCategoia",
                 { params: { id: $scope.subcategoria } }
         ).success(function (data) {
             $scope.dadosProdutos = data;
         }).error(function (data) {
           
         });

    };

    //Ver Detalhes do Produto
    $scope.produtoVerDetalhes = '';
    $scope.VerDetalhesProdutos = function (id) {
        $scope.produtoVerDetalhes = $filter('filter')($scope.dadosProdutos, { IdProduto: id })[0];
    }

    //Popula o dropdown de categorias
    CarregaDadosCategoria();

    //*****************************INSERINDO PRODUTOS NO CARRINHO**************************************

    //Insere os produtos no carrinho
    $scope.produtosCarrinho = [];
    $scope.existeProdutoNoCarrinho = '';
    $scope.AdicionarProdutosCarrinho = function (id) {

        $scope.existeProdutoNoCarrinho = $filter('filter')($scope.produtosCarrinho, { IdProduto: id })[0]

        if ($scope.existeProdutoNoCarrinho !== null && $scope.existeProdutoNoCarrinho !== undefined)
            alert('Produto encontra-se no carrinho.');
        else {
            $scope.produtosCarrinho.push($scope.produtoVerDetalhes);
            $filter('filter')($scope.produtosCarrinho, { IdProduto: id })[0].Quantidade = 1
            $scope.MostrarTotalProdutos();
        }
    }

    //Atualiza a quantidade no array
    $scope.AtualizarQuantidade = function (quantidade, id) {

        var totalQuantidade = $filter('filter')($scope.produtosCarrinho, { IdProduto: id })[0].QuantidadeProdutos

        if (quantidade > totalQuantidade) {
            alert('A quantidade não pode ser maior que a quantidade em estoque.');
        } else {
            $filter('filter')($scope.produtosCarrinho, { IdProduto: id })[0].Quantidade = quantidade
            $scope.MostrarTotalProdutos();
        }
    };

    //Remove os Produtos do Carrinho
    $scope.RemoverProdutosCarrinho = function ($index) {
        if (window.confirm("Deseja exluir o produto ?")) {
            $scope.produtosCarrinho.splice($index, 1);
            $scope.MostrarTotalProdutos();
        }
    }


    //*****************************RESUMO DA COMPRA**************************************
    $scope.ValorProdutosEntrega = '';
    $scope.TotalItens = '';
    $scope.MostrarTotalProdutos = function () {
        var total = 0;
        var totalItens = 0;
        for (var i = 0; i < $scope.produtosCarrinho.length; i++) {
            var x = $scope.produtosCarrinho[i];
            total += (x.Valor * x.Quantidade);
            totalItens++;
        }
        $scope.ValorProdutosEntrega = total;
        $scope.TotalItens = totalItens;
    }


    //*****************************ENTREGA**************************************
    //Popula os produtos no dropdown de subcategoria
    $scope.dadosTipoEntrega = [];
    $scope.CarregaDadosTipoEntrega = function () {
        $http.get(
             "http://localhost:55049/api/tipoentrega/RetornarTodasTipoEntrega"
         ).success(function (data) {
             $scope.dadosTipoEntrega = data;
         }).error(function (data) {
             alert("Erro ao carregar os produtos.");
         });
    };

    //Verifica o tipo da entrega para habilitar o endereco quando for 1-"NO LOCAL" 2-"EM DOMICILIO"
    $scope.tipoEntregaHabilitaEndereco = false;
    $scope.VerificaTipoEntregaEndereco = function (habilitaTipoEntregaEndereco) {
        //EM DOMICILIO
        if (habilitaTipoEntregaEndereco == 1) {
            $scope.tipoEntregaHabilitaEndereco = true;
        }
        else {
            $scope.tipoEntregaHabilitaEndereco = false;
        }
    };


    $scope.CarregaDadosTipoEntrega();

    //*****************************VALIDAÇÃO**************************************
    $scope.VerificandoCampos = function (isValid) {
        if (isValid) {
            $scope.InserirCompra();
        }

    };

    //*****************************INSERINDO A COMPRA NO BANCO DE DADOS**************************************
    $scope.InserirCompra = function () {
        //INSERIR COMPRA (POST)



    };

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