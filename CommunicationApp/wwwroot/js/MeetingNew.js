$(() => {

    $('#AddMeetingDate').click(function (e) {
        e.preventDefault();
        addChosenDate();
    });

    $('#AddPersonToMeeting').click(function (e) {
        e.preventDefault();
        addChosenPersons();
    });

    $("body").on("click",
        ".list-group .delete-date",
        function () {
            var li = $(this).closest("li");
            li.remove();
        });

    $("body").on("click",
        ".list-group .delete-person",
        function () {
            var li = $(this).closest("li");
            li.remove();
            var id = li.attr("data-id");
            var text = li.html();
            $('select').append('<option data-id="' + id + '" value="' + id + '">' + text + '</option>');
        });

    $("#meeting-submit").on("click",
        function (e) {
            e.preventDefault();
            createMeeting();
        });

    $('#inputStartTime').on("change",
        function (e) {
            var date = $('#inputDate').val();
            var startTime = $('#inputStartTime').val();
            var startDate = moment(date + ' ' + startTime);
            var oldDate = new Date(startDate);
            var hour = oldDate.getHours();
            var newHour = hour + 1;
            var minute = oldDate.getMinutes();
            var padHour = pad(newHour, 2);
            var padMinutes = pad(minute, 2);
            $('#inputEndTime').val(padHour+':'+padMinutes);
            
        });

    $('#inputEndTime').on("change",
        function (e) {
            
            var date = $('#inputDate').val();
            var startTime = $('#inputStartTime').val();
            var endTime = $('#inputEndTime').val();
            var startDate = moment(date + ' ' + startTime);
            var endDate = moment(date + ' ' + endTime);
            var oldStartDate = new Date(startDate);
            var oldEndDate = new Date(endDate);
            var startHour = oldStartDate.getHours();
            var endHour = oldEndDate.getHours();
            var startMinute = oldStartDate.getMinutes();
            var endMinute = oldEndDate.getMinutes();

            var newHour = endHour - 1;
            var padHour = pad(newHour, 2);
            var padMinutes = pad(endMinute, 2);
            var newTime = padHour + ':' + padMinutes;

            if (endHour < startHour) {
                $('#inputStartTime').val(newTime);
            }
            if (endHour == startHour && endMinute < startMinute) {
                $('#inputStartTime').val(newTime);
            }

        });

    function pad(str, max) {
        str = str.toString();
        return str.length < max ? pad("0" + str, max) : str;
    }

    function addChosenDate() {

        var date = $('#inputDate').val();
        var startTime = $('#inputStartTime').val();
        var endTime = $('#inputEndTime').val();

        var startDate = date + " " + startTime;
        var endDate = date + " " + endTime;

        if (date != "" && startTime != "" && endTime != "") {

            var selectOptions = '<li data-start="' +
                startDate +
                '" data-end="' +
                endDate +
                '" class="list-group-item list-group-item-action">' +
                date +
                ', ' +
                startTime +
                '-' +
                endTime +
                '<button class="delete-date btn btn-sm btn-danger float-right"><i class="fas fa-trash-alt"></i></button></li>';
            $('#list-tab-dates').last().append(selectOptions);

        } else {
            alertify.error("Fyll i datum, start- och sluttid");
        }
    };

    function addChosenPersons() {

        var persons = $('select option:selected').toArray();

        if (persons.length > 0) {

            $.each(persons, function (i, obj) {
                var id = $(this).val();
                var text = $(this).text();

                var selectOptions = '<li data-id="' +
                    id +
                    '" class="list-group-item list-group-item-action">' +
                    text +
                    '<button class="delete-person btn btn-sm btn-danger float-right"><i class="fas fa-trash-alt"></i></button></li>';
                $('#list-tab-persons').last().append(selectOptions);
            });
            $('select option:selected').remove();
        } else {
            alertify.error("Välj en eller flera personer att bjuda in.");
        }
    };

    function createMeeting() {
        var object = {};
        var title = $("#meeting-title").val();
        var description = $("#meeting-description").val();
        var meetingId = $("#meeting-id").val();
        var persons = $('select option:selected').toArray();
        var i = 0;

        var meetingDates = [];
        $("#list-tab-dates li").each(function (i, obj) {
            var date = {};
            var start = $(this).attr("data-start");
            var end = $(this).attr("data-end");

            date.start = moment(start);
            date.end = moment(end);
            meetingDates[i] = date;
            i++;
        });

        var meetingPersons = [];
        $("#list-tab-persons li").each(function (i, obj) {
            var id = $(this).attr("data-id");
            meetingPersons[i] = id;
            i++;
        });

        if (title != "" && description != "" && meetingDates.length > 0 && meetingPersons.length > 0) {
            $("#meeting-submit").attr("disabled", "disabled");
        

            object.title = title;
            if (meetingId == "") {
                object.id = "00000000-0000-0000-0000-000000000000";
            } else {
                object.id = meetingId;
            }
            object.description = description;
            object.meetingDates = meetingDates;
            object.meetingPersons = meetingPersons;

            if (meetingId == "") {

                $.ajax({
                    type: "POST",
                    url: "/api/meeting/addMeeting",
                    data: JSON.stringify(object),
                    contentType: "application/json; charset=utf-8",
                    success: function () {
                        alertify.success("Dina ändringar har sparats");
                        setTimeout(function () { window.location.href = "/Meeting/MyMeetings"; }, 2000);
                    },
                    error: function (xhr) {
                        $('#meeting-submit').removeAttr('disabled');
                        alertify.error("Något gick snett");
                    }
                });

            } else {

                $.ajax({
                    type: "POST",
                    url: "/api/meeting/editMeeting",
                    data: JSON.stringify(object),
                    contentType: "application/json; charset=utf-8",
                    success: function () {
                        alertify.success("Dina ändringar har sparats");
                        setTimeout(function () { window.location.href = "/Meeting/MyMeetings"; }, 2000);
                    },
                    error: function (xhr) {
                        $('#meeting-submit').removeAttr('disabled');
                        alertify.error("Något gick snett");
                    }
                });

            }
        } else {
            alertify.error("Fyll i samtliga fält");
        }
    }
});