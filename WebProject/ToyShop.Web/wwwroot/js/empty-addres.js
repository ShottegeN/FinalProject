document.addEventListener("DOMContentLoaded", function () {
    var form = document.querySelector("form");
    var deliveryTypeSelect = document.getElementById("deliveryType");
    var addressFields = document.querySelectorAll(".delivery-address input");
    var deliveryAddressSection = document.querySelector(".delivery-address");

    // Disable address fields when "Лично вземане" is selected
    function toggleAddressFields() {
        var deliveryType = deliveryTypeSelect.value;

        if (deliveryType === "Лично вземане") {
            // Hide address section and remove required attributes
            deliveryAddressSection.style.display = "none";
            addressFields.forEach(function (input) {
                input.disabled = true;  // Disable input fields
            });
        } else {
            // Show address section and enable fields
            deliveryAddressSection.style.display = "block";
            addressFields.forEach(function (input) {
                input.disabled = false;  // Enable input fields
            });
        }
    }

    // Call the function initially to set the state based on the default delivery type
    toggleAddressFields();

    // Update when the delivery type changes
    deliveryTypeSelect.addEventListener("change", function () {
        toggleAddressFields();
    });
});
