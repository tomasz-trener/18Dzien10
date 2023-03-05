
$(document).ready(function () {

    $("#btnPolicz").click(function () {

        var a = $("#txtLiczba1HTML").val();
        var b = $("#txtLiczba2HTML").val();

        $.ajax({
            method: "POST",
            url: "DefaultServer.aspx",
            data: { liczba1: a, liczba2: b }
        })
            .done(function (msg) {
                //msg to co zwraca server
                $("#wynik").html(msg);
            });



    });


});



