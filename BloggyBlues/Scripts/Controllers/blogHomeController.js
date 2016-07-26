var blogHomeController = function ($scope) {
    $scope.models = {
        Bob: 'I workin'
    
    };
    $scope.offWork = function () {
        $scope.models.Bob = 'I done workin';
    };
}

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
blogHomeController.$inject = ['$scope'];