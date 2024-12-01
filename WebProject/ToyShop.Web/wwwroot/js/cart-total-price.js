// Listen for changes in quantity input fields
document.querySelectorAll('.quantity-input').forEach(function (input) {
    input.addEventListener('change', function () {
        // Get the new quantity value and associated product ID
        const newQuantity = parseInt(input.value) || 1;  // Default to 1 if invalid input
        const productId = input.dataset.productId;

        // Send AJAX request to update the quantity
        $.ajax({
            url: '/Cart/UpdateProductQuantity', // The controller action to call
            type: 'POST',
            data: {
                productId: productId,
                quantity: newQuantity
            },
            success: function (response) {
                // Optionally handle success (e.g., notify user or refresh cart UI)
                console.log('Quantity updated successfully');
                updateTotalPrice();  // Recalculate the total price after updating quantity
            },
            error: function (xhr, status, error) {
                // Handle any error
                console.error('Error updating quantity:', error);
            }
        });
    });
});

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

// Call updateTotalPrice on page load to ensure the initial total price is calculated
window.onload = updateTotalPrice;
