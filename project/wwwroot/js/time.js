$(document).ready(function () {

    var breakfastTimes = {
        "9:00": "09:00",
        "09:30": "09:30",
        "10:00": "10:00",
        "10:30": "10:30",
        "11:00": "11:00",
        "11:30": "11:30",
    };

    var lunchTimes = {
        "13:00": "13:00",
        "13:30": "13:30",
        "14:00": "14:00",
        "14:30": "14:30",
        "15:00": "15:00",
    };

    var dinnerTimes = {
        "18:00": "18:00",
        "18:30": "18:30",
        "19:00": "19:00",
        "19:30": "19:30",
        "20:00": "20:00",
        "20:30": "20:30",
        "21:00": "21:00",
        "21:30": "21:30",
        "22:00": "22:00",
    };

    //adopted from https://stackoverflow.com/questions/1801499/how-to-change-options-of-select-with-jquery
    $(function () {

        var $el = $("#Time");
        $('input[type=radio]').change(function (e) {

           // console.log("changed");
            var radioValue = $("input[type=radio]:checked").val();
            console.log(radioValue);

            if (radioValue == "Breakfast") {
                $el.empty(); // remove old options
                $.each(breakfastTimes, function (key, value) {
                    $el.append($("<option></option>")
                        .attr("value", value).text(key));
                });
            }
            if (radioValue == "Lunch") {
                $el.empty(); // remove old options
                $.each(lunchTimes, function (key, value) {
                    $el.append($("<option></option>")
                        .attr("value", value).text(key));
                });
            }
            if (radioValue == "Dinner") {
                 $el.empty(); // remove old options
            $.each(dinnerTimes, function (key, value) {
                $el.append($("<option></option>")
                    .attr("value", value).text(key));
            });
            }

        });
    });


});