// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    // Check if the '.hot-deal' container exists on the page
    const hotDealContainer = document.querySelector('.hot-deal');

    if (hotDealContainer) {
        // Initialize Slick with the necessary options
        $(hotDealContainer).slick({
            autoplay: true,        // Auto scroll through items
            autoplaySpeed: 50000,   // 5 seconds per item
            arrows: true,          // Show arrows for navigation
            dots: false,            // Show dots for navigation
            infinite: true,        // Infinite scroll
            slidesToShow: 1,       // Show 1 promotion at a time
            slidesToScroll: 1,     // Scroll 1 promotion at a time
            responsive: [
                {
                    breakpoint: 768,   // For smaller screens
                    settings: {
                        slidesToShow: 1 // Show 1 promotion on smaller screens
                    }
                }
            ]
        });
    }
});
