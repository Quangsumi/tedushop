(function (app) {
    app.filter('statusFilter', function () {
        return function (input) {
            return input ? "Kich hoat" : 'Khoa';
        }
    });
})(angular.module('tedushop.common'));