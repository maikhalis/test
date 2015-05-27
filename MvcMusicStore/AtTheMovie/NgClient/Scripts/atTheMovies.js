(function () {
    // create module
    var app = angular.module("atTheMovies", ["ngRoute"]);

    // generate rooting
    var config = function ($routeProvider) {
        $routeProvider
            .when("/list", { templateUrl: "/ngclient/views/list.html" })
            .when("/details/:id", { templateUrl: "/ngclient/views/details.html" })
            .otherwise({ redirectTo: "/list" });
    };

    // add rooting to main module
    app.config(config);

    // define constant
    app.constant("movieApiUrl", "/api/movie/");

}());