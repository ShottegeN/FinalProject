// This function checks if the custom category input should be displayed
function toggleCustomCategoryInput() {
    var customCategoryInput = document.getElementById('customCategoryInput');
    var categoryDropdown = document.getElementById('categoryDropdown');

    // If the selected value is 'new', show the custom category input
    if (categoryDropdown.value === 'new') {
        customCategoryInput.style.display = 'block';
    } else {
        customCategoryInput.style.display = 'none';
    }
}

// Event listener for the category dropdown change
document.getElementById('categoryDropdown').addEventListener('change', toggleCustomCategoryInput);

// On page load, check the initial state of the category dropdown
window.addEventListener('load', function () {
    toggleCustomCategoryInput(); // Ensure the input is shown/hidden based on the initial selection

    // Check if the 'new' category was selected previously
    var customCategoryInput = document.getElementById('customCategoryInput');
    var categoryDropdown = document.getElementById('categoryDropdown');

    // Show custom category input if 'new' was selected
    if (categoryDropdown.value === 'new') {
        customCategoryInput.style.display = 'block';
    }

    // Separate check for validation errors of NewCategoryName only
    var newCategoryError = document.querySelector('[data-valmsg-for="NewCategoryName"]');
    if (newCategoryError && newCategoryError.textContent.trim() !== '') {
        customCategoryInput.style.display = 'block'; // Show input if validation failed for NewCategoryName
    }

    // Check if the error message for NewCategoryName is already displayed
    var existingCategoryError = document.querySelector('[data-valmsg-for="Product.Category"]');
    if (existingCategoryError && existingCategoryError.textContent.trim() !== '') {
        var selectedCategory = categoryDropdown.value;

        // If 'new' category was selected, make sure the custom input is shown, otherwise hide it
        if (selectedCategory !== 'new') {
            customCategoryInput.style.display = 'none'; // Hide input if an existing category is selected
        }
    }
});

// Add this function to clear the NewCategoryName if the custom category input is hidden and an existing category is selected
function clearNewCategoryIfNeeded() {
    var categoryDropdown = document.getElementById('categoryDropdown');
    var newCategoryInput = document.getElementById('customCategory');
    var customCategoryInput = document.getElementById('customCategoryInput');

    // If an existing category is selected and the custom input is hidden, clear the new category value
    if (categoryDropdown.value !== 'new' && customCategoryInput.style.display === 'none') {
        newCategoryInput.value = ''; // Clear the new category field
    }
}

// Attach the function to the form submission event
document.querySelector('form').addEventListener('submit', clearNewCategoryIfNeeded);
