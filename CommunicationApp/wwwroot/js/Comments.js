

$("body").on("click",
    ".comment-submit",
    async function (e) {
        e.preventDefault();
        var form = $(this).closest(".comment-form");
        var commentSection = form.parent();
        var commentWall = commentSection.find(".comment-wall");
        var commentCount = commentSection.find(".comment-count");
        var textarea = form.find("textarea");
        var blogPost = $(this).closest(".blog-post");
        var id = blogPost.find("input").val();
        var user = form.find("input").val();

        var comment = {};
        comment.author = textarea.attr("data-author");
        comment.text = textarea.val();
        comment.date = moment();
        comment.blogPost = id;

      

            await $.ajax({
                type: "POST",
                url: "/api/comments/create",
                data: JSON.stringify(comment),
                contentType: "application/json; charset=utf-8",
                success: function (r) {
                    appendComment(r, commentWall, user);
                    var count = parseInt(commentCount.html());
                    var newCount = count + 1;
                    commentCount.html(newCount.toString());
                    textarea.val("");
                    alertify.success("Dina ändringar har sparats");
                },
                error: function (xhr) {
                    alertify.error("Något gick snett!");
                }
            });


    });

function appendComment(r, commentWall, user) {
    var newComment =
        '<div class="row comment-post"><div class= "col-10" ><div class="alert alert-primary"><p>' + r.text +
        '</p><span class="small">' +
        r.author +
        ' | ' +
        r.date +
        '</span></div></div><div class="col-2">';
    if (user == r.email) {
        newComment += '<button data-id="'+r.commentId.toString()+'" class="comment-delete btn btn-danger"><i class="fas fa-trash-alt"></i></button>';
    }
    newComment += '</div></div>';

    commentWall.append(newComment);
};

$("body").on("click",
    ".comment-delete",
    function () {
        var id = $(this).attr("data-id");
        var post = $(this).closest(".comment-post");
        var blogPost = $(this).closest(".blog-post");
        var commentCount = blogPost.find(".comment-count");
        alertify
            .okBtn("Ok")
            .cancelBtn("Avbryt")
            .confirm("Är du säker på att du vill radera denna kommentar?<br /> Detta går ej att ångra.",
                async function (ev) {
                    ev.preventDefault();
                    try {

                        $.ajax({
                            type: "POST",
                            url: "/api/comments/delete",
                            data: JSON.stringify(id),
                            contentType: "application/json; charset=utf-8",
                            dataType: "json"
                        });
                    } catch (error) {
                        console.error(error);
                    }
                    alertify.success("Kommentaren är borttagen");
                    post.remove();
                    var count = parseInt(commentCount.html());
                    var newCount = count - 1;
                    commentCount.html(newCount.toString());
                },
                function (ev) {
                    ev.preventDefault();
                    alertify.error("Inga ändringar har skett");
                });
    });