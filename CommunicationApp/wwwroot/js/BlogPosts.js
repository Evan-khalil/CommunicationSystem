
$(document).ready(function () {
    loadCategories();
});

$('#btnSubmit').click(function (event) {
    if (!$('#blogCategories').val().length) {
        showErrorMessage('En kategori måste väljas för denna blogtyp.');
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
    request.blogType = getBlogType();

    if (request.blogType == -1) {
        clearCategories();
        return;
    }

    $.ajax({
        url: '/Api/Category/GetCategories',
        data: {
            blogType: request.blogType
        }
    }).done(function (data) {
        clearCategories();
        data.forEach(function (item) {
            addCategory(item.name);
        });


        var pathArray = window.location.pathname.split('/');
        console.log(pathArray[3])

        $.ajax({
            url: '/Api/Category/GetCategoryForPost',
            data: {
                id: pathArray[3]
            }
        }).done(function (data) {
            for (var i = 0; i < data.length; i++) {
                $("#blogCategories option").filter(`[value='${data[i].name}']`).attr('selected', true);
            }
        }).fail(function (xhr, textStatus, errorThrown) {
            showErrorMessage('Misslyckades att sätta kategorier. ' + errorThrown);
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