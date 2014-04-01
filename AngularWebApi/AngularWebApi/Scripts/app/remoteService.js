var cardsServices = angular.module('cardsServices', ['ngResource']);

cardsServices.factory('Cards', ['$resource',
  function ($resource) {
      return $resource('/Api/Cards', {}, {
          query: { method: 'GET', params: { }, isArray: true }
      });
  }]);