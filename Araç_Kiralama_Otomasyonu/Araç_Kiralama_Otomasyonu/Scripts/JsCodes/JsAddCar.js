var pics = [];
document.getElementById("dropContainer").ondragover = document.getElementById("dropContainer").ondragenter = function (evt) {
    evt.preventDefault();
};

document.getElementById("dropContainer").ondrop = function (evt) {
    if (evt.dataTransfer.files.length <= 4) {
        for (var i = 0; i < evt.dataTransfer.files.length; i++) {
            if (pics.length <= 4) {
                pics.push(evt.dataTransfer.files[i].name);
            }
            else {
                alert("En fazla 4 adet fotoğraf ekleyebilirsiniz.");
            }

        }
        document.getElementById("firstPhoto").value = "/Resimler/" + pics[0].toString();
        document.getElementById("secondPhoto").value = "/Resimler/" + pics[1].toString();
        document.getElementById("thirthPhoto").value = "/Resimler/" + pics[2].toString();
        document.getElementById("fourthPhoto").value = "/Resimler/" + pics[3].toString();
        $("#pic1").attr("src", document.getElementById("firstPhoto").value);
        $("#pic2").attr("src", document.getElementById("secondPhoto").value);
        $("#pic3").attr("src", document.getElementById("thirthPhoto").value);
        $("#pic4").attr("src", document.getElementById("fourthPhoto").value);
    } else {
        alert("En fazla 4 adet fotoğraf ekleyebilirsiniz.");
    }

    evt.preventDefault();
};