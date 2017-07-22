/// <reference path="E:\Programming\Test\Pack-9602\Session29-960431\WebAppDemo\Scripts/jquery-1.12.4.js" />

(function () { 
    $(document).ready(function () {
        //alert("Document Is Ready!");
        $("#submit").on("click", function () {
            var todo = $("#todo").val();
            var date = $("#date").val();

            var $row = $("<tr></tr>");


            $row.append($("<td></td>").html(todo))
                .append($("<td></td>").html(date))
                .append($("<td></td>").append(
                        $("<button></button>")
                        .addClass("btn btn-danger btn-sm")
                        .append($("<span></span>").addClass("fa fa-times"))
                    ))

            .prependTo($("#todo-list tbody"));

            $("#todo").val("");
            $("#date").val("");
        }); 
    });

})();