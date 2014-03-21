var cardsControllers = angular.module('cardsControllers', []);

cardsControllers.controller('cardsListController', ['$scope', '$http', function ($scope, $http) {
    $http.get('all.json').success(function (data) {
        var cards = [];

        angular.forEach(data, function(block) {
            angular.forEach(block.expansions, function(expansion) {
                angular.forEach(expansion.cards, function(card) {
                    cards.push(card);
                });
            });
        });
        
        $scope.cards = cards;
    });
}]);