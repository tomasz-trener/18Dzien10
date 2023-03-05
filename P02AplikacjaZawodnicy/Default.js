

$(document).ready(function () {


    $('#txtSzukaj').keypress(function (event) {
        if (event.keyCode == 13) {
            szukaj();
        }
    });


    $("#dvSzukaj").click(function () {
        szukaj();
    });

});


function szukaj() {
    $("#imgLoading").show();

    var filtrDane = $("#txtSzukaj").val();

    $.ajax({
        method: "POST",
        url: "DefaultServer.aspx",
        data: { filtr: filtrDane }
    })
        .done(function (msg) {

            $("#dvTabelkaKontener").html(msg);
            $("#imgLoading").hide();
        });
}