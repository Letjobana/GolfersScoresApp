function GetData() {
    $.ajax({
        type: "GET",
        url: 'https://localhost:44383/api/Players/GetPlayers',
        success: function (data) {
            mainModel.playersList (data);
            console.log(data);

        }, error: function (error) {
            console.log(error);
        }
    });
}