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

        // Add the values to the cells
        cell1.textContent = classEntry.className;
        cell2.textContent = classEntry.numberOfPeople;
        cell3.textContent = classEntry.description;

        // Create a remove button
        const removeButton = document.createElement("button");
        removeButton.textContent = "Remove";
        removeButton.onclick = function () {
            removeClass(index);
        };
        cell4.appendChild(removeButton);

        // Add events to the table row
        newRow.addEventListener("click", () => rowClick(classEntry));
        newRow.addEventListener("dblclick", () => rowDoubleClick(index));
        newRow.addEventListener("mouseover", () => rowMouseover(newRow));
        newRow.addEventListener("mouseout", () => rowMouseout(newRow));
    });
}

// Function to remove a class entry by index
function removeClass(index) {
    classData.splice(index, 1); // Remove the entry from the array
    updateTable(); // Update the table after removal
}

// Row click event - Logs the class details and highlights the row
function rowClick(classEntry) {
    console.log("Row clicked: ", classEntry);
    // Highlight the clicked row
    const rows = document.getElementById("classTable").getElementsByTagName("tr");
    Array.from(rows).forEach(row => row.classList.remove("highlight"));
    event.target.closest("tr").classList.add("highlight");
}

// Row double-click event - Logs details and removes the row
function rowDoubleClick(index) {
    console.log("Row double-clicked: Removing class");
    removeClass(index);
}

// Mouseover event - Changes row background color on hover
function rowMouseover(row) {
    row.style.backgroundColor = "#f0f0f0";
}

// Mouseout event - Reverts row background color
function rowMouseout(row) {
    row.style.backgroundColor = "";
}

// Input focus event - Adds border and background color to active input
document.getElementById("className").addEventListener("focus", function () {
    this.style.borderColor = "#4CAF50";
});
document.getElementById("numberOfPeople").addEventListener("focus", function () {
    this.style.borderColor = "#4CAF50";
});
document.getElementById("description").addEventListener("focus", function () {
    this.style.borderColor = "#4CAF50";
});

// Input blur event - Resets border color when input loses focus
document.getElementById("className").addEventListener("blur", function () {
    this.style.borderColor = "";
});
document.getElementById("numberOfPeople").addEventListener("blur", function () {
    this.style.borderColor = "";
});
document.getElementById("description").addEventListener("blur", function () {
    this.style.borderColor = "";
});
