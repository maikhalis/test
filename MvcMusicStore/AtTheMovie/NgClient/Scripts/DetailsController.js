(function (app) {
    var DetailController = function ($scope, $routeParams, movieService) {
        var id = $routeParams.id;
        movieService
             .getById(id)
             .success(function (data) {
                 $scope.movie = data;
             });
    };

    app.controller("DetailController", DetailController);

}(angular.module("atTheMovies")));