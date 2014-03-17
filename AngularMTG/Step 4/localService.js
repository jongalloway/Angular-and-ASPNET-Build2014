var cardsServices = angular.module('cardsServices', ['ngResource']);

cardsServices.factory('Cards', ['$resource',
  function ($resource) {
      return $resource('all.json', {}, {
          query: { method: 'GET', params: { }, isArray: true }
      });
  }]);