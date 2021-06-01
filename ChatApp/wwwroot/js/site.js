// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$("#txtChatBox").keypress(function (e) {
    if (e.which === 13 && !e.shiftKey) {
        e.preventDefault();

        $(this).closest("form").submit();
    }
});
