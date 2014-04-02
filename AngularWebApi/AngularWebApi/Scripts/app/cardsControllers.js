var cardsControllers = angular.module('cardsControllers', []);

cardsControllers.controller('cardsListController', ['$scope', '$http', 'Cards', function ($scope, $http, Cards) {
    var cards = [];
    Cards.query(function (cards) {
        angular.forEach(cards, function (card) {
            cards.push(card);
        });
    $scope.cards = cards;
});

$scope.cardsCount = 10;
}]);