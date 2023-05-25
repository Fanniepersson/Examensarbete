window.slideshow = {
    init: function () {
        // Get the carousel element
        var carousel = document.querySelector('.carousel');
        const firstImg = carousel.querySelectorAll("img")[0];
        let firstImgWidth = firstImg.clientWidth + 14;
       
        //// Get the left and right arrow elements
        var leftArrow = document.getElementById('left');
        var rightArrow = document.getElementById('right');

        //// Define the current slide index
        //var currentSlideIndex = 0;

        //// Add click event listeners to the arrows


        leftArrow.addEventListener('click', function () {
            carousel.scrollLeft -= firstImgWidth;
        });

        rightArrow.addEventListener('click', function () {
            carousel.scrollLeft += firstImgWidth;
        });


        //leftArrow.addEventListener('click', function () {
        //    currentSlideIndex = (currentSlideIndex - 1 + carousel.children.length) % carousel.children.length;
        //    carousel.style.transform = 'translateX(-' + (currentSlideIndex * 100) + '%)';
        //});

        //rightArrow.addEventListener('click', function () {
        //    currentSlideIndex = (currentSlideIndex + 1) % carousel.children.length;
        //    carousel.style.transform = 'translateX(-' + (currentSlideIndex * 100) + '%)';
        //});


    }
}

