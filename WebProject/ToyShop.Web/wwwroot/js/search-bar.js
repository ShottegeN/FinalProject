// Attach event listener when the form is submitted
document.querySelector("form").addEventListener("submit", function (event) {
    var globalCategory = document.querySelector("select[name='globalCategory']").value;
    var query = document.querySelector("input[name='query']").value;

    // Construct the filter value
    if (globalCategory != "all") {
        var filter = "globalCategory" + "-" + globalCategory + "-" + query;
    } else {
        var filter = "globalCategory" + "-" + query;
    }
        
    // Set the value of the hidden filter field
    document.querySelector("input[name='filter']").value = filter;
});
