/// <reference path="E:\Programming\Test\Pack-9602\Session29-960431\WebAppDemo\Scripts/jquery-1.12.4.js" />

(function () { //iife

    //$(document).ready(function () {
    $(function(){ //document.ready
        //alert("Document Is Ready!");
        $.ajaxSetup({
            "async": true,
            "crossDomain": true,
            }
        );

        $(document).ajaxSend(function () {
            $(".loader-bg").show();
        });
        $(document).ajaxComplete(function () {
            $(".loader-bg").hide();
        });

        refreshTable();
        $("#submit").on("click", function () {
            $.ajax({
                url: "http://localhost:51982/Todo/Create",
                method: "POST",
                data: { Title: $("#todo").val(), PersianDate: $("#persiandate").val() }
            })
            .done(function (data) {
                refreshTable();
            });

            $("#todo").val("");
            $("#persiandate").val("");
        });

        //$("#load-raw-response").on("click", function () {
        //    $("#raw-response").load("EventHandelingDemo.html");
        //});

        $("#refresh").on("click", function () {
            refreshTable();
        });
    });
    function refreshTable() {
        $.getJSON("http://localhost:51982/Todo/List", function (data) {
            //console.log(data);
            $("#todo-list tbody").html("");
            $.each(data, function (key, value) {
                addRow(value.Title, value.PersianDate);
            });
        })
        .done(function () {
            $("#message").addClass("alert-success").html("لیست برنامه ها با موفقیت به روز شد").show();
        })
        .fail(function () {
            $("#message").addClass("alert-danger").html("خطایی در بروز رسانی لیست رخ داده است").show();

        });
    }
    function addRow(todo, date)
    {
        var $row = $("<tr></tr>");
        $row.append($("<td></td>").html(todo))
            .append($("<td></td>").html(date))
            .append($("<td></td>").append(
                    $("<button></button>")
                    .addClass("btn btn-danger btn-xs")
                    .append($("<span></span>").addClass("fa fa-times"))
                    .on('click', function () {
                        //$(this).parent().parent().remove();
                        $(this).parentsUntil("tbody").remove();
                        //$(this).parent().siblings().css("background-color", "red");
                        //$(this).parent().prev().css("background-color", "red");
                    })
                ))

        .prependTo($("#todo-list tbody"));
    }


})();