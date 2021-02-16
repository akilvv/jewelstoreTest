var jstoreapp = angular.module('jstoreapp', ['ngRoute', 'ngResource', 'ngCookies', 'ngDialog', 'ui.grid', 'ui.grid.treeView', 'ui.grid.pagination', 'ui.grid.selection', 'ui.grid.exporter', 'ui.grid.edit', 'ui.grid.cellNav', 'ui.bootstrap'])


jstoreapp.factory('sharedService', function (ngDialog, $location) {

    var methods = {};
    var region = {};

    methods.openWithoutOverlay = function (msg) {
        if (msg == null || msg == "")
            msg = "Processing ....";
        var dispdlg = ngDialog.open({
            template: '<div style="height:20%"><h2 id="proctext">' + msg + '</h2>' +
                '<div class="procloader"></div></div>',
            className: 'ngdialog-theme-default',
            showClose: false,
            plain: true,
            overlay: false
        });
        return dispdlg;
    };

    methods.ShowUsrMessage = function (msg,path) {
        if (msg == null || msg == "")
            msg = "Processing ....";
        var dispdlg = ngDialog.open({
            //template: '<div style="height:20%;width:100%"><p class="usermessage-header" style="background-color:#ffeaa0;color:black;font-weight:bold">Self-service Portal</p><br><p class="usermessage-content" id="proctext">' + msg + '</p></div>',
            template: '<div class="modal-dialog" role="document"><div class= "modal-content"><div class="modal-header" style="background-color:#009eb4;"><h5 class="modal-title" style="color:white;">Self-service Portal</h5></div><div class="modal-body"><p>' + msg + '</p></div></div></div>',
            className: 'ngdialog-theme-default',
            showClose: true,
            plain: true,
            overlay: true,
            preCloseCallback: function () {
                  if (path == "Reload")
                    window.location.reload();
                return true;
            }
        });
        return dispdlg;
    };

    return methods;
});

jstoreapp.config(function ($routeProvider, $locationProvider, $httpProvider) {
    //initialize get if not there
    if (!$httpProvider.defaults.headers.get) {
        $httpProvider.defaults.headers.get = {};
    }

    //disable IE ajax request caching
    $httpProvider.defaults.headers.get['If-Modified-Since'] = 'Mon, 26 Jul 1997 05:00:00 GMT';
    // extra
    $httpProvider.defaults.headers.get['Cache-Control'] = 'no-cache';
    $httpProvider.defaults.headers.get['Pragma'] = 'no-cache';
    $routeProvider
        .when('/', {
            templateUrl: 'templates/Jewelstore.html',
            controller: 'JewelstoreController'
        })
        .otherwise({
            templateUrl: 'templates/Jewelstore.html',
            controller: 'JewelstoreController'
        });
});

jstoreapp.config(['$httpProvider', function ($httpProvider) {
    //initialize get if not there
    if (!$httpProvider.defaults.headers.get) {
        $httpProvider.defaults.headers.get = {};
    }

    //disable IE ajax request caching
    $httpProvider.defaults.headers.get['If-Modified-Since'] = 'Mon, 26 Jul 1997 05:00:00 GMT';
    // extra
    $httpProvider.defaults.headers.get['Cache-Control'] = 'no-cache';
    $httpProvider.defaults.headers.get['Pragma'] = 'no-cache';
}]);