// Function to update the total price dynamically
function updateTotalPrice() {
    let totalPrice = 0;

    // Loop through all products and calculate the total price
    document.querySelectorAll('.product-row').forEach(function (row) {
        const quantity = parseInt(row.querySelector('.quantity').dataset.quantity) || 1; // Get quantity from dataset
        const price = parseFloat(row.querySelector('.price').dataset.price) || 0; // Get price from dataset
        totalPrice += price * quantity; // Update total price calculation
    });

    // Update the total price displayed
    document.getElementById('total-price').textContent = totalPrice.toLocaleString('bg-BG', { style: 'currency', currency: 'BGN' });
}

// Call updateTotalPrice on page load to ensure the initial total price is calculated
window.onload = updateTotalPrice;
