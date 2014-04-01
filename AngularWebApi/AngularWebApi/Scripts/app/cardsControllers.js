var cardsControllers = angular.module('cardsControllers', []);

cardsControllers.controller('cardsListController', ['$scope', '$http', 'Cards', function ($scope, $http, Cards) {
    var cards = [];
    Cards.query(function (cards) {
        angular.forEach(cards, function (card) {
            cards.push(card);
            if (localStorage) {
                var savedInfo = localStorage.getItem(card.id);
                if (savedInfo !== null) {
                    card.textEn = savedInfo;
                }
            }
        });
    $scope.cards = cards;
});

$scope.cardsCount = 10;
}]);

cardsControllers.controller('cardDetailController', function ($scope, $routeParams) {
    var cards = $scope.$parent.cards;
    for (var index = 0; index < cards.length; index++) {
        if (cards[index].id == $routeParams.cardId) {
            $scope.card = cards[index];
            break;
        }
    }

    $scope.update = function () {
        if (!localStorage) {
            return;
        }

        localStorage.setItem($scope.card.id, $scope.card.textEn);
    };
});