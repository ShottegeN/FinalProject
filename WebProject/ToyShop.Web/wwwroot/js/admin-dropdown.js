// Toggle the visibility of the admin dropdown menu
document.getElementById("admin-dropdown-link").addEventListener("click", function (event) {
    event.preventDefault(); // Prevent the default anchor behavior
    var dropdownMenu = document.getElementById("admin-dropdown-menu");
    dropdownMenu.style.display = dropdownMenu.style.display === "block" ? "none" : "block";
});

// Optional: Hide the dropdown menu when clicking outside of it
window.addEventListener("click", function (event) {
    var dropdown = document.getElementById("admin-dropdown-menu");
    var link = document.getElementById("admin-dropdown-link");

    if (!dropdown.contains(event.target) && !link.contains(event.target)) {
        dropdown.style.display = "none";
    }
});