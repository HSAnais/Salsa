function menuClick() {
    var links = document.getElementById("links");
    if (links.style.display === "block")
        links.style.display = "none";
    else
        links.style.display = "block";
}

function bkgSwitch() {
    var text = document.getElementsByClassName("selectItem");

    if (document.body.style.backgroundColor === "white")
    {
        document.body.style.backgroundColor = "black";
        document.body.style.color = "white";

        //datalists
        for (var i = 0; i < text.length; i++)
        {
            text[i].style.color = "white";
        }        
    }
    else
    {
        document.body.style.backgroundColor = "white";
        document.body.style.color = "black";

        //datalists
        for (var i = 0; i < text.length; i++) {
            text[i].style.color = "black";
        } 
    }
}