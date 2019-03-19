function menuClick() {
    var links = document.getElementById("links");
    if (links.style.display === "block")
        links.style.display = "none";
    else
        links.style.display = "block";
}

function bkgSwitch() {
    if (document.body.style.backgroundColor === "white")
    {
        document.body.style.backgroundColor = "black";
        document.body.style.color = "white";
    }
    else
    {
        document.body.style.backgroundColor = "white";
        document.body.style.color = "black";
    }
}