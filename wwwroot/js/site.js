$(document).ready(function () {
    var shrinkOn = 100;

    $(window).on('scroll', function () {
        var scroll = $(window).scrollTop();

        if (scroll >= shrinkOn) {
            $('#navbar').addClass('shrink');
        } else {
            $('#navbar').removeClass('shrink');
        }
    });
});
