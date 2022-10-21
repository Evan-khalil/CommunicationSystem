document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar');

    var calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: 'dayGridMonth',
        locale: 'sv',
        eventClick: function (info) {
            var event = info.event;
            details(event.id);
        }
    });
    

    calendar.setOption('locale', 'sv');


    $(function getMeetings() {
        var event = {};
        var i = 0;
        var url = "/api/meeting/getMeetingsToCalendarPersonal";
        $.get(url,
            function (r) {
                if (r != null) {
                    $.each(r,
                        function(i, obj) {

                            calendar.addEvent({
                                title: obj.title,
                                start: obj.start,
                                end: obj.end,
                                id: obj.id,
                                url: "#"
                            });

                        });

                }
            });
    });




    calendar.render();


    function details(eventId) {
        var id = eventId;
        var url = "/meeting/info";
        $.get(url,
            { id: id },
            function (data) {
                $('.modal-body').html(data);
            });

        var event = calendar.getEventById(id);

        $("#myModalLabel").html(event.title);
        $("#modal-calendar").modal("show");

    }

});




