var cardsControllers = angular.module('cardsControllers', []);

cardsControllers.controller('cardsListController', ['$scope', function ($scope) {
    var cards = [{ id: 10 }, { id: 11 }];

    $scope.cards = cards;
}]);