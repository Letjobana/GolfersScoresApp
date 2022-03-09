
$(document).ready(function () {
    GetData();
});

function ViewModel() {
    var self = this;
    self.name = ko.observable();
    self.score = ko.observable();
    self.playersList = ko.observable();
}
var mainModel = new ViewModel();
$(function () {
    try {
        var isBound = !!ko.dataFor(document.getElementById('foamtest-container'));
        if (!isBound) {
            ko.applyBindings(mainModel, document.getElementById("foamtest-container"));
        }
    }
    catch (ex) {
        alert(ex.message);
    }
});