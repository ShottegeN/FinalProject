// This part handles updating the URL when the user changes the filters.
function updateFilter() {
    // Get the selected values for sorting and page size
    var sortBy = document.getElementById("sortBy").value;
    var pageSize = document.getElementById("pageSize").value;

    // Redirect to the same page with updated query parameters
    var url = new URL(window.location.href);
    url.searchParams.set('sortBy', sortBy);
    url.searchParams.set('pageSize', pageSize);
    window.location.href = url.toString(); // Navigate to the updated URL
}

// This part ensures the selected options reflect the server-side values after the page reloads
window.addEventListener('load', function () {
    // Retrieve the values for sortBy and pageSize from ViewData
    var sortBy = document.getElementById('sortBy').dataset.sortBy;
    var pageSize = document.getElementById('pageSize').dataset.pageSize;

    // Set the selected option for sortBy
    var sortBySelect = document.getElementById('sortBy');
    for (var i = 0; i < sortBySelect.options.length; i++) {
        if (sortBySelect.options[i].value === sortBy) {
            sortBySelect.options[i].selected = true;
        }
    }

    // Set the selected option for pageSize
    var pageSizeSelect = document.getElementById('pageSize');
    for (var i = 0; i < pageSizeSelect.options.length; i++) {
        if (pageSizeSelect.options[i].value === pageSize) {
            pageSizeSelect.options[i].selected = true;
        }
    }

    // Ensure checkboxes are correctly checked based on the query string
    const urlParams = new URLSearchParams(window.location.search);

    // Get the filter (checkbox value) from the query string (it's now named 'filter')
    const selectedFilter = urlParams.get('filter'); // Get the selected filter from the query string 

    // Check all checkboxes with the name 'filter' and compare their value with the selected filter in the URL
    const checkboxes = document.querySelectorAll('input[type="checkbox"][name="filter"]');
    checkboxes.forEach(function (checkbox) {
        if (checkbox.value === selectedFilter) {
            checkbox.checked = true; // Check the checkbox if its value matches the selected filter
        }
    });
});
