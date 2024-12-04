document.addEventListener('DOMContentLoaded', function () {
    // Delivery cost mapping
    const deliveryCosts = {
        "Лично вземане": 0.00, // Free pickup
        "До офис на куриер": 5.00, // Delivery to courier office
        "До адрес": 7.00 // Delivery to address
    };

    // Select elements
    const deliveryTypeSelect = document.getElementById('deliveryType');
    const deliveryAddressSection = document.querySelector('.delivery-address'); // Delivery address section
    const deliveryCostElement = document.getElementById('deliveryCost');
    const finalPriceElement = document.getElementById('finalPrice');
    const priceElement = document.getElementById('price');

    // Function to parse the price in Bulgarian format
    function parsePrice(priceString) {
        return parseFloat(priceString.replace(/\./g, '').replace(',', '.')); // Handle thousand separators and decimal points
    }

    // Parse the base price
    let basePrice = parsePrice(priceElement.textContent);

    // Function to update delivery cost and final price
    function updatePrices() {
        const selectedDeliveryType = deliveryTypeSelect.value;
        const deliveryCost = deliveryCosts[selectedDeliveryType] || 0;

        // Update delivery cost display
        deliveryCostElement.textContent = deliveryCost > 0
            ? `${deliveryCost.toLocaleString('bg-BG', { style: 'currency', currency: 'BGN' })}`
            : "Безплатна";

        // Update final price display
        const finalPrice = basePrice + deliveryCost;
        finalPriceElement.textContent = finalPrice.toLocaleString('bg-BG', { style: 'currency', currency: 'BGN' });

        // Hide or show delivery address fields based on delivery type
        if (selectedDeliveryType === "Лично вземане") {
            deliveryAddressSection.style.display = 'none'; // Hide address fields
        } else {
            deliveryAddressSection.style.display = 'block'; // Show address fields
        }
    }

    // Attach event listener to delivery type dropdown
    deliveryTypeSelect.addEventListener('change', updatePrices);

    // Initial update
    updatePrices();

});
