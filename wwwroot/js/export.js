document.addEventListener("DOMContentLoaded", function () {
    // Add event listener to the exportButton
    var exportButton = document.getElementById("exportButton");
    if (exportButton) {
        exportButton.addEventListener("click", function () {
            // Make AJAX request
            var xhr = new XMLHttpRequest();
            xhr.open("GET", "/Sort/ExportSortedSequences", true);
            xhr.setRequestHeader("Content-Type", "application/json");
            xhr.onreadystatechange = function () {
                if (xhr.readyState === XMLHttpRequest.DONE) {
                    if (xhr.status === 200) {
                        // Success: Handle the response
                        var responseData = JSON.parse(xhr.responseText);
                        console.log(responseData); // Output the response data
                    } else {
                        // Error: Handle the error
                        console.error("Error:", xhr.statusText);
                    }
                }
            };
            xhr.send();
        });
    }
});
