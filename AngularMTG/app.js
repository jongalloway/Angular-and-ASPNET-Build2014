var mainApp = angular.module('mainApp', ['ngRoute', 'ngAnimate', 'cardsControllers', 'cardsServices']);

mainApp.config([
    '$routeProvider',
    function($routeProvider) {
        $routeProvider.
            when('/cards', {
                templateUrl: 'Views/list.html',
                controller: 'cardsListController'
            }).
            when('/cards/:cardId', {
                templateUrl: 'Views/detail.html',
                controller: 'cardDetailController'
            }).
            otherwise({
                redirectTo: '/cards'
            });
    }
]);

mainApp.filter('filterAndReduce', function () {
    return function (cards, count, query) {
        var temp = cards.slice(0, count);

        if (!query) {
            return temp;
        }

        var filtered = [];

        query = query.toLowerCase();

        angular.forEach(temp, function (card) {
            if (card.nameEn.toLowerCase().indexOf(query) !== -1) {
                filtered.push(card);
            }
        });

        return filtered;
    };
});