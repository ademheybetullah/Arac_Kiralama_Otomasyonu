 $(document).ready(function () {

            var date_range = [,];
            date_range = @Html.Raw(Json.Encode(ViewBag.Dates));
            var newArr = [];
            while (date_range.length) newArr.push(date_range.splice(0, 2));
            $(".firstDatePicker").datepicker({
                minDate: 0,
                beforeShowDay: function (date) {

                    var string = $.datepicker.formatDate('mm-dd-yy', date);

                    for (var i = 0; i < newArr.length; i++) {

                        if (Array.isArray(newArr[i])) {

                            var from = new Date(newArr[i][0]);
                            var to = new Date(newArr[i][1]);
                            var current = new Date(string);

                            if (current >= from && current <= to) return false;
                        }

                    }
                    return [newArr.indexOf(string) == -1]
                }

            });
            $(".firstDatePicker").bind("change", function () {
                var firstDate = $('#firstDate').datepicker("getDate");
                $(".lastDatePicker").datepicker({
                    minDate: firstDate,
                    beforeShowDay: function (date) {
                        var string = $.datepicker.formatDate('mm-dd-yy', date);

                        for (var i = 0; i < newArr.length; i++) {

                            if (Array.isArray(newArr[i])) {

                                var from = new Date(newArr[i][0]);
                                var to = new Date(newArr[i][1]);
                                var current = new Date(string);

                                if (current >= from && current <= to) return false;
                            }

                        }
                        return [newArr.indexOf(string) == -1]
                    }
                });
            });


    });