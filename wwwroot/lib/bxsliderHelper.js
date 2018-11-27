$(window).on('load', function () {


    var slider = $('.bxslider').bxSlider({
        mode: 'fade',
        adaptiveHeight: true,
        slideWidth: 600


    });


    slider.on("mousewheel", function (event, delta, deltaX, deltaY) {

        if (delta > 0) {
            slider.goToPrevSlide();
        }
        if (deltaY < 0) {
            slider.goToNextSlide();
        }
        event.stopPropagation();
        event.preventDefault();

    });
});
