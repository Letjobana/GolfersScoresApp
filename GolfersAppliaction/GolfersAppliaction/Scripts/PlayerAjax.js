function GetData() {
    $.ajax({
        type: "GET",
        url: 'https://localhost:44383/api/Players/GetPlayers',
        success: function (data) {
            mainModel.playersList(data);
            console.log(data);

        }, error: function (error) {
            console.log(error);
        }
    });
}

function AddPlayer(player) {
    $.ajax({
        type: "POST",
        url: 'https://localhost:44383/api/Players/AddPlayerScore',
        data: { player: player },
        success: function (data) {
            console.log(data);

        }, error: function (error) {
            console.log(error);
        }
    });
}

function GetWinner() {
    $.ajax({
        type: "Get",
        url: 'https://localhost:44383/api/Players/GetPlayers',
        success: function (data) {

            mainModel.leaderScore(data);
        }, error: function (error) {
            console.log(error);
        }
    });
}
