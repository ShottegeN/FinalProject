document.querySelectorAll('.quantity-input').forEach(function (input) {
    input.addEventListener('change', function () {
        const newQuantity = parseInt(input.value) || 1;  // Default to 1 if invalid input
        const productId = input.dataset.productId;

        // Update the corresponding hidden input for BoughtQuantity
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

window.onload = updateTotalPrice;
