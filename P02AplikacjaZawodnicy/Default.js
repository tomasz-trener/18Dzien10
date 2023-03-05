

$(document).ready(function () {
    szukaj(1); // pierwsze wejscie na strone

    $('#txtSzukaj').keypress(function (event) {
        if (event.keyCode == 13) {
            var strona = parseInt($("#wyborStrony").val());
            szukaj(strona);
        }
    });


    $("#dvSzukaj").click(function () {
        var strona = parseInt($("#wyborStrony").val());
        szukaj(strona);
    });

    $("#btnPrzejdz").click(function () {
        var strona = parseInt($("#wyborStrony").val());
        szukaj(strona);
    });

});


function szukaj(nrStrony) {
    $("#imgLoading").show();

    var filtrDane = $("#txtSzukaj").val();

    $.ajax({
        method: "POST",
        url: "DefaultServer.aspx",
        data: { filtr: filtrDane, ilePokazac: 3, nrStrony: nrStrony }
    })
        .done(function (msg) {

            $("#dvTabelkaKontener").html(msg);
            $("#imgLoading").hide();
        });
}