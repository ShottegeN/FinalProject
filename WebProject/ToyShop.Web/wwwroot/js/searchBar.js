// Attach event listener when the form is submitted
document.querySelector("form").addEventListener("submit", function (event) {
    var category = document.querySelector("select[name='globalCategory']").value;
    var query = document.querySelector("input[name='query']").value;

    // Construct the filter value
    var filter = "globalCategory-" + category + "-" + query;
    
    // Set the value of the hidden filter field
    document.querySelector("input[name='filter']").value = filter;
});
