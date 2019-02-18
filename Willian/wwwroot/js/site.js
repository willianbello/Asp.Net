// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function typeEffect(element, speed) {
    var text = $(element).text();
    $(element).html('');

    var i = 0;
    var timer = setInterval(function () {
        if (i < text.length) {
            $(element).append(text.charAt(i));
            i++;
        } else {
            clearInterval(timer);
        }
    }, speed);
}

$(document).ready(function () {

    var speed = 100;
    var delay = $('span').text().length * speed + speed;
    setTimeout(function () {
        $('#texto1').show();
        $('#texto1').css('display', 'block');
        typeEffect($('#texto1'), speed);
    }, 1000);
    setTimeout(function () {
        $('#texto2').show();
        $('#texto2').css('display', 'block');
        typeEffect($('#texto2'), speed);
    }, 2500);
    setTimeout(function () {
        $('#texto3').show();
        $('#texto3').css('display', 'block');
        typeEffect($('#texto3'), speed);
    }, 3500);

});
