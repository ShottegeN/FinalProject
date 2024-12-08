// Function to preserve the selected value in the dropdown
document.addEventListener('DOMContentLoaded', function () {
    const urlParams = new URLSearchParams(window.location.search); // Get query params
    const selectedStatus = urlParams.get('status'); // Get 'status' value from URL

    if (selectedStatus !== null) {
        const dropdown = document.getElementById('orderStatusFilter');
        dropdown.value = selectedStatus; // Set the selected value in the dropdown
    }
});