
$(document).ready(function () {
    $('#participants option').prop('selected', false);
});

$('#btnAddParticipant').click(function (event) {
    event.preventDefault();

    var participantId = $("#allUsers").val();
    var participantName = $("#allUsers option:selected").text();
    addParticipant(participantId, participantName);
})

function addParticipant(participantId, participantName) {
    if (!participantExists(participantId)) {
        $('#participants').append($('<option>', {
            value: participantId,
            text: participantName
        }));
    }
}

function participantExists(participant) {
    var exists = false;
    $("#participants option").each(function () {
        var result = $(this).val().toLowerCase().localeCompare(participant.toLowerCase());
        if (result == 0) {
            exists = true;
        }
    });

    return exists;
}

$('#btnRemoveParticipant').click(function (event) {
    event.preventDefault();

    $('#participants option:selected').remove();
})

$('#btnSave').click(function (event) {
    $('#participants option').prop('selected', true);
})
