document.addEventListener('DOMContentLoaded', function () {
    const deliveryCosts = {
        "Лично вземане": 0.00, // Free pickup
        "До офис на куриер": 5.00, // Delivery to courier office
        "До адрес": 7.00 // Delivery to address
    };

    // Get required DOM elements
    const deliveryTypeSelect = document.getElementById('deliveryType');
    const deliveryCostElement = document.getElementById('deliveryCost');
    const finalPriceElement = document.getElementById('finalPrice');
    const hiddenPriceInput = document.getElementById('hiddenPrice');
    const hiddenDeliveryPriceInput = document.getElementById('hiddenDeliveryPrice');
    const hiddenTotalPriceInput = document.getElementById('hiddenTotalPrice');

    // Parse the base price once at the start (from the hidden input)
    const basePrice = parseFloat(hiddenPriceInput.value.replace(',', '.')); // Ensure correct parsing for numbers like 43,50

    // Function to format numbers for Bulgarian currency
    function formatPriceBGN(value) {
        return value.toFixed(2).replace('.', ',') + " лв"; // Bulgarian format: comma for decimals
    }

    // Function to update prices based on selected delivery type
    function updatePrices() {
        const selectedDeliveryType = deliveryTypeSelect.value;
        let deliveryCost = parseFloat(deliveryCosts[selectedDeliveryType] || 0.00); // Ensure it's a number

        // Edge case: If "Лично вземане" is selected, deliveryCost is always 0
        if (selectedDeliveryType === "Лично вземане") {
            deliveryCost = 0.00; // Explicitly set to 0 for clarity
        }

        // Calculate the total price
        const totalPrice = basePrice + deliveryCost;

        // Update visible delivery cost
        deliveryCostElement.textContent = deliveryCost > 0
            ? formatPriceBGN(deliveryCost)
            : "Безплатна";

        // Update visible final price and hidden inputs
        finalPriceElement.textContent = formatPriceBGN(totalPrice);
        hiddenDeliveryPriceInput.value = deliveryCost.toFixed(2); // Update hidden delivery price
        hiddenTotalPriceInput.value = totalPrice.toFixed(2); // Update hidden total price

        // Debugging (to ensure all values are correct)
        console.log("Selected Delivery Type:", selectedDeliveryType);
        console.log("Base Price:", basePrice);
        console.log("Delivery Cost:", deliveryCost);
        console.log("Total Price:", totalPrice);
    }

    // Attach event listener to delivery type dropdown
    deliveryTypeSelect.addEventListener('change', updatePrices);

    // Initial price update on page load
    updatePrices();
});

