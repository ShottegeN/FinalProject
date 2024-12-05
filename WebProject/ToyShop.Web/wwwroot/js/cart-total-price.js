document.querySelectorAll('.quantity-input').forEach(function (input) {
    // Block keyboard input
    input.addEventListener('keydown', function (event) {
        event.preventDefault(); // Disable typing
    });

    // Allow only mouse or spinner changes
    input.addEventListener('change', function () {
        let newQuantity = parseInt(input.value) || 1; // Default to 1 if invalid
        const productId = input.dataset.productId;

        // Ensure quantity is valid and within allowed bounds
        if (newQuantity < 1) {
            newQuantity = 1;
            input.value = newQuantity; // Reset invalid input
        }

        // Update hidden input for BoughtQuantity
        const hiddenInput = document.querySelector(`input[name="Products[${productId}].BoughtQuantity"]`);
        if (hiddenInput) {
            hiddenInput.value = newQuantity;
        }

        // Send AJAX request to update the quantity (optional)
        $.ajax({
            url: '/Cart/UpdateProductQuantity',
            type: 'POST',
            data: {
                productId: productId,
                quantity: newQuantity
            },
            success: function (response) {
                console.log('Quantity updated successfully');
                updateTotalPrice();
            },
            error: function (xhr, status, error) {
                console.error('Error updating quantity:', error);
            }
        });
    });
});

// Function to update the total price dynamically
function updateTotalPrice() {
    let totalPrice = 0;

    document.querySelectorAll('.quantity-input').forEach(function (input) {
        const quantity = parseInt(input.value) || 1;
        const price = parseFloat(input.dataset.price);
        totalPrice += price * quantity;
    });

    document.getElementById('total-price').textContent = totalPrice.toLocaleString('bg-BG', { style: 'currency', currency: 'BGN' });
}

// Initialize total price on page load
window.onload = updateTotalPrice;
