// Function to update the countdown for each promotion
function updateCountdown(promotionId, endDate) {
    var countdown = document.getElementById('countdown-' + promotionId);
    if (!countdown) return; // Safety check

    var daysElement = countdown.querySelector('#days-' + promotionId);
    var hoursElement = countdown.querySelector('#hours-' + promotionId);
    var minutesElement = countdown.querySelector('#minutes-' + promotionId);
    var secondsElement = countdown.querySelector('#seconds-' + promotionId);

    function updateTimer() {
        var now = new Date();
        var endTime = new Date(endDate); // Ensure 'endDate' is parsed correctly
        var remainingTime = endTime - now;

        if (remainingTime <= 0) {
            // Timer reached zero, reset the countdown
            daysElement.textContent = "0";
            hoursElement.textContent = "0";
            minutesElement.textContent = "0";
            secondsElement.textContent = "0";
            return;
        }

        // Calculate days, hours, minutes, and seconds
        var days = Math.floor(remainingTime / (1000 * 60 * 60 * 24));
        var hours = Math.floor((remainingTime % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((remainingTime % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((remainingTime % (1000 * 60)) / 1000);

        // Update elements
        daysElement.textContent = days;
        hoursElement.textContent = hours;
        minutesElement.textContent = minutes;
        secondsElement.textContent = seconds;
    }

    // Call updateTimer every second
    setInterval(updateTimer, 1000);
}
