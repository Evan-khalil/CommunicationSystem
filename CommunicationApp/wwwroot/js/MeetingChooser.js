$(() => {

    $('#AcceptDates').click(function (event) {
        event.preventDefault();
        acceptingDates();
    });

    $("#cb-decline input").click(function (event) {
        uncheckMeetingDates();
    });

    $('#cb-meetingDates input').click(function (event) {
        uncheckDecline();
    });

    function uncheckMeetingDates() {
        $("#cb-meetingDates input").each(function (i, obj) {
            var checkBox = $(this);
            checkBox.prop("checked", false);
            i++;
        });
    }

    function uncheckDecline() {
        $("#cb-decline input").each(function (i, obj) {
            var checkBox = $(this);
            checkBox.prop("checked", false);
            i++;
        });
    }

    function acceptingDates() {
        var object = {};
        var i = 0;
        var acceptedMeetingDates = [];
        var declinedMeeting;
        var index = 0;

        $("#cb-meetingDates input").each(function (i, obj)
        {
            var checkBox = $(this);
            var meetingDateId = checkBox.is(":checked") ? checkBox.val() : null;

            if (meetingDateId != null)
            {
                acceptedMeetingDates[index] = meetingDateId;
                index++;
            }
            i++;
        });

        $("#cb-decline input").each(function (i, obj) {
            var checkBox = $(this);
            declinedMeeting = checkBox.is(":checked") ? checkBox.val() : null;

            i++;
        });

        if (declinedMeeting) {
            object.DeclinedMeeting = declinedMeeting;

            $('#AcceptDates').attr("disabled", "disabled");
            $.ajax({
                type: "POST",
                url: "/api/meeting/declineMeeting",
                data: JSON.stringify(object),
                contentType: "application/json; charset=utf-8",
                success: function () {
                    alertify.success("Tack för ditt svar.");
                    setTimeout(function () { window.location.href = "/Meeting/Invites"; }, 2000);
                },
                error: function (xhr) {
                    $('#AcceptDates').removeAttr('disabled');
                    alertify.error("Något gick snett.");
                }
            });
        } else if (acceptedMeetingDates.length > 0) {
            object.AcceptedMeetingDates = acceptedMeetingDates;

            $('#AcceptDates').attr("disabled", "disabled");
            $.ajax({
                type: "POST",
                url: "/api/meeting/acceptMeetingDate",
                data: JSON.stringify(object),
                contentType: "application/json; charset=utf-8",
                success: function () {
                    alertify.success("Tack för dina mötesval");
                    setTimeout(function () { window.location.href = "/Meeting/Invites"; }, 2000);
                },
                error: function (xhr) {
                    $('#AcceptDates').removeAttr('disabled');
                    alertify.error("Något gick snett.");
                }
            });
        } else {
            alertify.error("Välj minst ett alternativ.");
        }
    }
});