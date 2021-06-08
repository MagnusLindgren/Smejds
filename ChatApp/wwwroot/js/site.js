// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*
$("#txtChatBox").keypress(function (e) {
    if (e.which === 13 && !e.shiftKey) {
        e.preventDefault();

        $(this).closest("form").submit();
    }
});*/

const colorThief = new ColorThief();
const img = new Image();

img.addEventListener('load', function () {
    colorThief.getColor(img);
)};

img.crossOrigin = 'Anonymous';
img.src = 'https://res.cloudinary.com/crunchbase-production/image/upload/c_lpad,f_auto,q_auto:eco/v1440924046/wi1mlnkbn2jluko8pzkj.png'