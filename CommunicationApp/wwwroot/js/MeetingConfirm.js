$(() => {

    $('.ConfirmMeetingDate').on("click",
        function () {
        var modal = $(this).parents(".modal-content");
        var input = modal.find("input");
        var object = {};
        var i = 0;
        var confirmedFinalDate = null;
        
            input.each(function (i, obj)
        {
            var radioBtn = $(this);
            var meetingDateId = radioBtn.is(":checked") ? radioBtn.val() : null;

            if (meetingDateId != null)
            {
                confirmedFinalDate = meetingDateId;
            }
            i++;
        });
       
        if (confirmedFinalDate != null) {
            object.FinalMeetingDate = confirmedFinalDate;

            $('#ConfirmMeetingDate').attr("disabled", "disabled");
            $.ajax({
                type: "POST",
                url: "/api/meeting/confirmMeetingDate",
                data: JSON.stringify(object),
                contentType: "application/json; charset=utf-8",
                success: function () {
                    alertify.success("Mötet har nu bokats in");
                    setTimeout(function () { window.location.href = "/Meeting/MyMeetings"; }, 2000);
                },
                error: function (xhr) {
                    alertify.error("Något gick snett");
                    $('#ConfirmMeetingDate').removeAttr('disabled');
                }
            });
        } else {
            alertify.error("Välj ett datum för mötet."); 
        }
        }
    );
});