var cardsControllers = angular.module('cardsControllers', []);

cardsControllers.controller('cardsListController', ['$scope', 'Cards', function ($scope, Cards) {
    Cards.query(function (blocks) {
        var cards = [];

        angular.forEach(blocks, function (block) {
            angular.forEach(block.expansions, function(expansion) {
                angular.forEach(expansion.cards, function(card) {
                    cards.push(card);
                });
            });
        });
        
        $scope.cards = cards;        
    });
    
    $scope.cardsCount = 10;    
}]);