
$(document).ready(function () {
    GetData();
    GetWinner();
});

function ViewModel() {
    var self = this;
    self.name = ko.observable();
    self.score = ko.observable();
    self.playersList = ko.observableArray();
    self.leaderScore = ko.observableArray();
   

    self.addPlayer = function (formelement) {
        var playerModel = {
            name: self.name(),
            score: self.score()
        };
        AddPlayer(playerModel);
    }
   
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