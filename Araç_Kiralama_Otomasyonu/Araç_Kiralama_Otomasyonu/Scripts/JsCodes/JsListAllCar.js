$(document).ready(function () {
    $("#MaxFiyat").on("keyup", function () {
        var maxFiyat = parseFloat($(this).val());
        $(".fiyatBilgisi").filter(function () {
            var fiyat = parseFloat($(this).text());
            if (fiyat > maxFiyat) {
                $(this).parent().parent().parent().css({ "display": "none", "visibility": "hidden" });
            } else {
                $(this).parent().parent().parent().css({ "display": "block", "visibility": "visible" });
            }
        });
    });
    $("#Skor").on("keyup", function () {
        var minSkor = parseFloat($(this).val());
        $(".skorBilgisi").filter(function () {
            var skor = parseFloat($(this).text());
            if (skor <= minSkor) {
                $(this).parent().parent().parent().css({ "display": "none", "visibility": "hidden" });
            } else {
                $(this).parent().parent().parent().css({ "display": "block", "visibility": "visible" });
            }
        });
    });
    $("#Sehir").on("keyup", function () {
        var sehir = $(this).val().toLowerCase();
        $(".sehirBilgisi").filter(function () {
            if ($(this).text().toLowerCase().indexOf(sehir) > -1) {
                $(this).parent().parent().parent().css({ "display": "block", "visibility": "visible" });
            } else {
                $(this).parent().parent().parent().css({ "display": "none", "visibility": "hidden" });
            }

        });
    });
    $("#Marka").on("keyup", function () {
        var marka = $(this).val().toLowerCase();
        $(".markaBilgisi").filter(function () {
            if ($(this).text().toLowerCase().indexOf(marka) > -1) {
                $(this).parent().parent().parent().css({ "display": "block", "visibility": "visible" });
            } else {
                $(this).parent().parent().parent().css({ "display": "none", "visibility": "hidden" });
            }
        });
    });
});