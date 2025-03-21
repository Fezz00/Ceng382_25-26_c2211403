// Global array to store class data
let classData = [];

// Add event listener for form submission
document.getElementById("classForm").addEventListener("submit", function (event) {
    event.preventDefault(); // Prevent the page from reloading on form submission

    const className = document.getElementById("className").value.trim();
    const numberOfPeople = document.getElementById("numberOfPeople").value.trim();
    const description = document.getElementById("description").value.trim();

    // Validate inputs
    if (className === "" || numberOfPeople === "" || description === "") {
        alert("Please fill out all fields.");
        return;
    }

    // Create a new class entry
    const newClass = {
        className: className,
        numberOfPeople: numberOfPeople,
        description: description,
    };

    // Add the class data to the array
    classData.push(newClass);

    // Update the table
    updateTable();

    // Clear form fields after submission
    document.getElementById("className").value = "";
    document.getElementById("numberOfPeople").value = "";
    document.getElementById("description").value = "";
});

// Function to update the table dynamically
function updateTable() {
    const tableBody = document.getElementById("classTable").getElementsByTagName("tbody")[0];
    tableBody.innerHTML = ""; // Clear the current table rows

    // Loop through the classData array and add rows
    classData.forEach((classEntry, index) => {
        const newRow = tableBody.insertRow();

        // Insert cells for class name, number of people, description, and actions
        const cell1 = newRow.insertCell(0);
        const cell2 = newRow.insertCell(1);
        const cell3 = newRow.insertCell(2);
        const cell4 = newRow.insertCell(3);

        cell1.textContent = classEntry.className;
        cell2.textContent = classEntry.numberOfPeople;
        cell3.textContent = classEntry.description;
        cell4.innerHTML = '<button class="deleteBtn">Delete</button>';

        // Add event listener for the delete button
        cell4.querySelector(".deleteBtn").addEventListener("click", function() {
            classData.splice(index, 1); // Remove the class data from the array
            updateTable(); // Update the table after deletion
        });
    });
}
