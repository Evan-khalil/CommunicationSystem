$('#btnSearch').click(function (event) {
    event.preventDefault();

    var searchCriteria = $("#searchCriteria").val();
    if (!searchCriteria || searchCriteria == "") {
        showErrorMessage("Sökvillkor måste anges.");
        return;
    }

    var blogType = $("#blogType").val();
    var searchTitleAndText = $('#searchTitleAndText').is(":checked");
    var searchAuthor = $('#searchAuthor').is(":checked");
    var searchCategories = $('#searchCategories').is(":checked");

    search(searchCriteria, blogType, searchTitleAndText, searchAuthor, searchCategories);
})

function search(searchCriteria, blogType, searchTitleAndText, searchAuthor, searchCategories) {
    var searchRequest = {};
    searchRequest.searchCriteria = searchCriteria;

    $.ajax({
        url: '/Search/Search',
        data: {
            searchCriteria: searchCriteria,
            blogType: blogType,
            searchTitleAndText: searchTitleAndText,
            searchAuthor: searchAuthor,
            searchCategories: searchCategories
        }
    }).done(function (data) {
        $("#searchResult").html(data);
    }).fail(function (xhr, textStatus, errorThrown) {
        showErrorMessage('Misslyckades att söka blogposter. ' + errorThrown);
    });
}

function showErrorMessage(message) {
    alertify.error(message);
}