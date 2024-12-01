// Function to update the total price dynamically
function updateTotalPrice() {
    let totalPrice = 0;
    // Loop through all quantity inputs and update total price
    document.querySelectorAll('.quantity-input').forEach(function (input) {
        const quantity = parseInt(input.value) || 1; // Default to 1 if invalid input
        const price = parseFloat(input.dataset.price); // Get price from data attribute
        totalPrice += price * quantity; // Update total price calculation
    });

    // Update the total price displayed
    document.getElementById('total-price').textContent = totalPrice.toLocaleString('bg-BG', { style: 'currency', currency: 'BGN' });
}

// Listen for changes in quantity input fields
document.querySelectorAll('.quantity-input').forEach(function (input) {
    input.addEventListener('input', updateTotalPrice); // Recalculate when quantity changes
});

// Call updateTotalPrice on page load to ensure the initial total price is calculated
window.onload = updateTotalPrice;