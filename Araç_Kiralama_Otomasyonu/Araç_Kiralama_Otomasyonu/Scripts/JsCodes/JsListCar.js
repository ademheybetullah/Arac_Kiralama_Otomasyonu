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
    $("#MaxDepozito").on("keyup", function () {
        var maxDeposit = parseFloat($(this).val());
        $(".depositBilgisi").filter(function () {
            var deposit = parseFloat($(this).text());
            if (deposit > maxDeposit) {
                $(this).parent().parent().parent().css({ "display": "none", "visibility": "hidden" });
            } else {
                $(this).parent().parent().parent().css({ "display": "block", "visibility": "visible" });
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
    $("#duzenle").click(function () {
        console.log("içerde");
        $("#deneme").replaceWith("<input class='form-control',name='CarId' value='New heading'/>");
    });
});