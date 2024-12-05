document.addEventListener("DOMContentLoaded", function () {
    const deliveryTypeDropdown = document.getElementById("deliveryType");
    const addressFields = document.querySelector(".delivery-address");

    // Default values for required fields
    const defaultValues = {
        "DeliveryAddress.CityName": "N/A",
        "DeliveryAddress.PostCode": "N/A",
        "DeliveryAddress.StreetName": "N/A",
        "DeliveryAddress.Number": "500"
    };

    // Reset address fields only if they contain default values
    function clearAddressFields() {
        addressFields.querySelectorAll("input, textarea").forEach(field => {
            const fieldName = field.name;
            if (fieldName in defaultValues && field.value === defaultValues[fieldName]) {
                field.value = ""; // Clear the value if it's the default
            }
        });
    }

    // Toggle address fields based on delivery type
    function toggleAddressFields() {
        const deliveryType = deliveryTypeDropdown.value;

        if (deliveryType === "Лично вземане") {
            addressFields.style.display = "none";
        } else {
            addressFields.style.display = "block";
            clearAddressFields();
        }
    }

    // Attach change event to the dropdown
    deliveryTypeDropdown.addEventListener("change", toggleAddressFields);

    // Call toggleAddressFields on page load
    toggleAddressFields();
});
