(function () {
    function addBox() {
        var container = document.getElementById("box-container");
        var location = document.getElementById("location");
        var seatCount = Number(location.value);
        container.innerHTML = "";
        for (var i = 1; i <= seatCount; i++) {
            var box = document.createElement("div");
            box.setAttribute("class", "box");
            box.setAttribute("style", "float:right;")
            box.innerHTML = i;
            container.appendChild(box);
        }
    }

    var myvar = "Sample";
    console.log(myvar);

    function firstFunction() {
        console.log(myvar);
    }

    function secondFunction() {
        console.log(myvar);
    }

    firstFunction();
    secondFunction();
})();

