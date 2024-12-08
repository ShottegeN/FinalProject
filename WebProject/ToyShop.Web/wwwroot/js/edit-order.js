
// Update delivery price and total price based on the delivery type
function updateDeliveryPrice() {
    var deliveryType = document.getElementById('DeliveryTypeDropdown').value;
    var deliveryPriceInput = document.getElementById('DeliveryPrice');
    var totalPriceInput = document.getElementById('TotalPrice');

    // Define delivery price based on the delivery type
    var deliveryPrice = 0;
    if (deliveryType === 'До адрес') {
        deliveryPrice = 7.00; // Price for home delivery
    } else if (deliveryType === 'До офис на куриер') {
        deliveryPrice = 5.00; // Price for courier office delivery
    } else if (deliveryType === 'Лично вземане') {
        deliveryPrice = 0.00; // Price for self-pickup
    }

    // Update the delivery price field and recalculate total price
    deliveryPriceInput.value = deliveryPrice.toFixed(2);

    // Assuming the base price is available in your model, add the delivery price to it
    var basePrice = parseFloat(document.getElementById('Price').value); // Assuming there's a field for the base price
    var totalPrice = basePrice + deliveryPrice;

    totalPriceInput.value = totalPrice.toFixed(2); // Update the total price
}

// Toggle the visibility of the Delivery Address section based on the selected delivery type
function toggleDeliveryAddressFields() {
    var deliveryType = document.getElementById('DeliveryTypeDropdown').value;
    var deliveryAddressSection = document.getElementById('deliveryAddressSection');

    if (deliveryType !== "Лично вземане") {
        deliveryAddressSection.style.display = "block"; // Show delivery address section
    } else {
        deliveryAddressSection.style.display = "none"; // Hide delivery address section
    }
}

// Ensure that the hidden input for OrderStatus is updated when the dropdown selection changes
document.getElementById('OrderStatusDropdown').addEventListener('change', function () {
    document.getElementById('OrderStatusHidden').value = this.value;
});

// Ensure that the hidden input for DeliveryType is updated when the dropdown selection changes
document.getElementById('DeliveryTypeDropdown').addEventListener('change', function () {
    document.getElementById('DeliveryTypeHidden').value = this.value;
});

// Call the function on page load to ensure correct display on initial load
document.addEventListener('DOMContentLoaded', function () {
    toggleDeliveryAddressFields();
    // Update delivery price and total price on page load based on initial delivery type
    updateDeliveryPrice();
});

