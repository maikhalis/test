(function (app) {
    var ListController = function ($scope, movieService) {
        movieService
            .getAll()
            .success(function (data) {
                 $scope.movies = data;
            });

        $scope.destroy = function (movie) {
            movieService.destroy(movie)
                        .success(function() {
                            removeMovieById(movie.Id);
                        });
        };

        var removeMovieById = function (id) {
            for (var i = 0 ; i < $scope.movies.length; i++) {
                if ($scope.movies[i].Id == id) {
                    $scope.movies.splice(i, 1);
                    break;
                }
            }
        };

    };

    // app is referenced on calling angular.module("xxx")
    app.controller("ListController", ListController);

}(angular.module("atTheMovies")));