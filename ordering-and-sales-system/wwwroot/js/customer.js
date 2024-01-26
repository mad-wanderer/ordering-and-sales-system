document.addEventListener('DOMContentLoaded', function () {
    setupAddCustomerPopup();
    setupEditButton();
})

function setupAddCustomerPopup() {
    // Event listener for popup and form submission
    document.querySelector(".add-product .add-btn button").addEventListener("click", function () {
        // Reset form fields and set button text to "Add Customer"
        document.getElementById('fName').value = '';
        document.getElementById('lName').value = '';
        document.getElementById('email').value = '';
        document.getElementById('contact').value = '';
        document.getElementById('address').value = '';
        document.querySelector('#add-btn2').innerText = 'Add Customer';

        openAddPopup();


        closeAddCustomerPopup();
        closeAddPopupUponSubmission();
    });
}

// Function to open popup
function openAddPopup() {
    const popup = document.getElementById('add-popup');

    // Open the popup
    popup.classList.add('active');
}

function closeAddCustomerPopup() {
    // Close button event listener
    document.querySelector('.close-add-btn').addEventListener('click', function () {
        // Close the popup
        document.querySelector('#add-popup').classList.remove('active');
    });
}

function closeAddPopupUponSubmission() {
    var addBtn2 = document.getElementById('add-btn2');
    // Event listener for form submission button
    addBtn2.addEventListener('click', function () {
        var First_Name = document.getElementById('fName').value;
        var Last_Name = document.getElementById('lName').value;
        var Email = document.getElementById('email').value;
        var Phone_Number = document.getElementById('contact').value;
        var Address = document.getElementById('address').value;

        var addCustomerData = {
            Customer_ID: "",
            First_Name: First_Name,
            Last_Name: Last_Name,
            Email: Email,
            Phone_Number: Phone_Number,
            Address: Address
        }

        addCustomerSendData(addCustomerData);
        // Close the popup
        document.getElementById('add-popup').classList.remove('active');
    });
}





function setupEditButton() {
    // Attach click event listeners to each edit button in the table
    document.querySelectorAll('.edit-btn').forEach((editButton) => {
        editButton.addEventListener('click', () => {
            // Get the corresponding table row
            const row = editButton.closest('tr');
            handleEditButtonClick(row);
        });
    });
}


function handleEditButtonClick(row) {
    // Get customer information from the table row
    const firstName = row.querySelector('td:nth-child(2)').innerText;
    const lastName = row.querySelector('td:nth-child(3)').innerText;
    const email = row.querySelector('td:nth-child(4)').innerText;
    const contactNumber = row.querySelector('td:nth-child(5)').innerText;
    const address = row.querySelector('td:nth-child(6)').innerText;

    // Populate the form fields
    document.getElementById('editfName').value = firstName;
    document.getElementById('editlName').value = lastName;
    document.getElementById('editemail').value = email;
    document.getElementById('editcontact').value = contactNumber;
    document.getElementById('editaddress').value = address;

    // Display the pop-up
    openEditPopup();
    closeEditCustomerPopup();
    closeEditPopupUponSubmission();
}

function openEditPopup() {
    const popup = document.getElementById('edit-popup');
    // Open the popup
    popup.classList.add('active');
}


function closeEditCustomerPopup() {
    // Close button event listener
    document.querySelector('.close-edit-btn').addEventListener('click', function () {
        // Close the popup
        document.querySelector('#edit-popup').classList.remove('active');
    });
}

function closeEditPopupUponSubmission() {
    var addBtn2 = document.getElementById('edit-btn2');
    // Event listener for form submission button
    addBtn2.addEventListener('click', function () {
        var First_Name = document.getElementById('editfName').value;
        var Last_Name = document.getElementById('editlName').value;
        var Email = document.getElementById('editemail').value;
        var Phone_Number = document.getElementById('editcontact').value;
        var Address = document.getElementById('editaddress').value;

        var editCustomerData = {
            Customer_ID: "",
            First_Name: First_Name,
            Last_Name: Last_Name,
            Email: Email,
            Phone_Number: Phone_Number,
            Address: Address
        }

        updateCustomerSendData(editCustomerData);
        // Close the popup
        document.getElementById('edit-popup').classList.remove('active');
    });
}

function addCustomerSendData(addCustomerData) {
    console.log(addCustomerData)
    fetch('/Home/AddCustomer', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(addCustomerData)
    })
        .then(data => {
            location.reload();
            //console.log('Product added successfully:', data);

            // Optionally, perform actions after successful product addition
        })
        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
}

function updateCustomerSendData(updatedCustomerData) {
    console.log("update")
 /*   console.log(updatedCustomerData)*/
    console.log(updatedCustomerData)
    fetch('/Home/UpdateCustomer', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(updatedCustomerData)
    })
        .then(data => {
            location.reload();
            //console.log('Product added successfully:', data);

            // Optionally, perform actions after successful product addition
        })
        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
}
