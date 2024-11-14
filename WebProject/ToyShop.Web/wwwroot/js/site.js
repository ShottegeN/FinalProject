// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    const homeLi = document.querySelector('.homeLi');  // Select the first <li> with class 'homeLi'
    const otherNavItems = document.querySelectorAll('ul.main-nav li:not(.homeLi)');  // Select all other <li> elements

    // Add click event to the homeLi
    if (homeLi) {
        homeLi.addEventListener('click', function () {
            // Ensure the homeLi gets the 'active' class
            this.classList.remove('active');
        });
    }    
    console.log('site.js is loaded!');
});
