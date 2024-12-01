// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    const hotDealContainer = document.querySelector('.hot-deal');
    const backgroundElement = document.querySelector('#hot-deal');

    if (hotDealContainer) {
        // Function to update the background image based on the promotion
        function updateBackgroundImage(slideIndex) {
            const promotion = $(hotDealContainer).slick('getSlick').$slides[slideIndex];
            const imageUrl = $(promotion).data('promotion-image'); // Get the promotion image URL

            if (imageUrl) {
                backgroundElement.style.backgroundImage = `url(${imageUrl})`; // Set the promotion image
            } else {
                // Fallback to the default image if the promotion image is not valid
                backgroundElement.style.backgroundImage = `url('/img/promotions/default-promotion.png')`;
            }
        }

        // Preload all promotion images (to avoid delay when switching from the last to the first promotion)
        $(hotDealContainer).find('.slick-slide').each(function () {
            const imageUrl = $(this).data('promotion-image');
            if (imageUrl) {
                const preloadImage = new Image();
                preloadImage.src = imageUrl; // Preload each image in the slider
            }
        });

        // Initialize Slick slider
        $(hotDealContainer).slick({
            autoplay: true,        // Auto scroll through items
            autoplaySpeed: 5000,   // 5 seconds per item
            arrows: true,          // Show arrows for navigation
            dots: false,           // Show dots for navigation
            infinite: true,        // Infinite scroll
            slidesToShow: 1,       // Show 1 promotion at a time
            slidesToScroll: 1,     // Scroll 1 promotion at a time
            responsive: [
                {
                    breakpoint: 768,   // For smaller screens (e.g., tablets and below)
                    settings: {
                        slidesToShow: 1, // Show 1 promotion on smaller screens
                        centerMode: false,  // Disable centerMode for smaller screens
                        focusOnSelect: true // Keep focus on select
                    }
                },
                {
                    breakpoint: 480,  // For very small screens (e.g., phones)
                    settings: {
                        slidesToShow: 1, // Show 1 promotion
                        centerMode: false,  // Disable centerMode for very small screens
                        focusOnSelect: true // Focus on selecting the promotion
                    }
                }
            ]
        });

        // Set the background image based on the first promotion immediately
        setTimeout(() => {
            updateBackgroundImage(0); // Manually trigger the first update
        }, 10); // Small delay to ensure slick initializes correctly before we set the background

        // Update background image after each slide change
        $(hotDealContainer).on('afterChange', function (event, slick, currentSlide) {
            updateBackgroundImage(currentSlide); // Update background image based on the current promotion
        });

        // Force an immediate update when transitioning from the last slide to the first one
        $(hotDealContainer).on('beforeChange', function (event, slick, currentSlide, nextSlide) {
            // Check if transitioning from the last slide to the first one (looping)
            if (nextSlide === 0 && currentSlide === slick.slideCount - 1) {
                updateBackgroundImage(nextSlide); // Update the background immediately on loop
            }
        });
    }
});

$.ajax({
    url: '/Cart/GetCartItemCount',  // This should match the route above
    type: 'GET',
    success: function (response) {
        console.log(response);  // Log the response for debugging
        $('.qty').text(response);  // Update the .qty element with the cart item count
    },
    error: function (xhr, status, error) {
        console.error('Error fetching cart item count:', error);
    }
});




