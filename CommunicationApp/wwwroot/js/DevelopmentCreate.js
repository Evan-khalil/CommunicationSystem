
$(document).ready(function () {
    loadCategories();
});

$('#btnSubmit').click(function (event) {
    if (!$('#blogCategories').val().length) {
        showErrorMessage('Ett projekt måste väljas för detta inlägget.');
        event.preventDefault();
    }
})

function getBlogType() {
    return $('#inputBlogType').children("option:selected").val();
}

function addCategory(category) {
    if (!categoryExists(category)) {
        $('#blogCategories').append($('<option>', {
            value: category,
            text: category
        }));
    }
}

function selectCategory(category) {
    $('#blogCategories option[value=' + category + ']').prop('selected', true);
}

function clearCategories() {
    $('#blogCategories').empty();
}

function loadCategories() {
    var request = {};
    request.BlogType = getBlogType();

    if (request.BlogType == -1) {
        clearCategories();
        return;
    }

    $.ajax({
        url: '/Api/Category/GetCategories',
        data: {
            blogType: request.BlogType
        }
    }).done(function (data) {
        clearCategories();
        data.forEach(function (item) {
            addCategory(item.name);
        });
    }).fail(function (xhr, textStatus, errorThrown) {
        showErrorMessage('Misslyckades att hämta kategorier. ' + errorThrown);
    });
}

$('#btnAddCategory').click(function (event) {
    event.preventDefault();

    var category = $("#newCategory").val();
    if (category != "" && category.length > 1) {
        addCategory(category);
        selectCategory(category);
        $("#newCategory").val("")
    }
    else {
        showErrorMessage("Kategorinamnet får inte vara tomt.")
    }
})

function categoryExists(category) {
    var exists = false;
    $("#blogCategories option").each(function () {
        var result = $(this).val().toLowerCase().localeCompare(category.toLowerCase());
        if (result == 0) {
            exists = true;
        }
    });

    return exists;
}

function showErrorMessage(message) {
    alertify.error(message);
}

$("#inputBlogType").change(function () {
    loadCategories();
});