$('#btn').on('click', function() {

    var user = $("#user")[0].value;

    var text = $("#text")[0].value;

    var comment = { user: user, text: text };
    $.post("/Home/Index", comment, null, "json");

    $('.comments').append(`
    <div style="display: flex; flex-direction:column; width: 80%; margin: 0 auto; border: 1px solid rgb(37,37,37); margin: 20px; padding: 10px; border-radius: 10px;">
    <h3 style="display: flex; width: 100%; margin: 1px;">
       ` + user + `
    </h3>
    <h4 style="height: 50px; width: 100%;border: 1px solid rgb(37,37,37);">
        ` + text + `
    </h4>
    </div>

`);

});