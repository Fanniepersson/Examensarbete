window.slideshow = {
    init: function () {

        // Get all wrapper elements
        var wrappers = document.querySelectorAll('.wrapper');

        wrappers.forEach(function (wrapper) {
            // Get the carousel element within the current wrapper
            var carousel = wrapper.querySelector('.carousel');
            const firstImg = carousel.querySelector("img");
            let firstImgWidth = firstImg.clientWidth + 14;

            // Get the left and right arrow elements within the current wrapper
            var leftArrow = wrapper.querySelector('.left-arrow');
            var rightArrow = wrapper.querySelector('.right-arrow');

            // Add click event listeners to the arrows within the current wrapper
            leftArrow.addEventListener('click', function () {
                carousel.scrollLeft -= firstImgWidth;
            });

            rightArrow.addEventListener('click', function () {
                carousel.scrollLeft += firstImgWidth;
            });
        });
    }
}

