﻿document.addEventListener('DOMContentLoaded', function () {
    showAddCustomerPopup();

})

function showAddCustomerPopup() {
    // Event listener for popup and form submission
    document.querySelector(".add-product .add-btn button").addEventListener("click", function () {
        // Reset form fields and set button text to "Add Customer"
        document.getElementById('fName').value = '';
        document.getElementById('lName').value = '';
        document.getElementById('email').value = '';
        document.getElementById('contact').value = '';
        document.getElementById('address').value = '';
        document.querySelector('#add-btn2').innerText = 'Add Customer';

        openPopup('Add Customer');


        closeAddCustomerPopup();
        closePopupUponSubmission();
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
    document.getElementById('fName').value = firstName;
    document.getElementById('lName').value = lastName;
    document.getElementById('email').value = email;
    document.getElementById('contact').value = contactNumber;
    document.getElementById('address').value = address;

    // Set button text to "Save Edit"
    document.querySelector('#add-btn2').innerText = 'Save Edit';

    // Display the pop-up
    openPopup('Edit Customer', true);
}

// Function to open popup
function openPopup(title, isEdit = false) {
    const popup = document.querySelector('.pop-up');
    const formTitle = document.querySelector('.pop-up h2');
    const submitButton = document.querySelector('#add-btn2');

    // Set form title
    formTitle.innerText = title;

    // Set button text to "Add Customer" for new entries
    if (!isEdit) {
        submitButton.innerText = 'Add Customer';
    }

    // Open the popup
    popup.classList.add('active');
}


function closeAddCustomerPopup() {
    // Close button event listener
    document.querySelector('.close-btn').addEventListener('click', function () {
        // Close the popup
        document.querySelector('.pop-up').classList.remove('active');
    });
}




function closePopupUponSubmission() {
    // Event listener for form submission button
    document.getElementById('add-btn2').addEventListener('click', function () {
        // Add your logic for form submission here

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
        document.querySelector('.pop-up').classList.remove('active');
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




    
/*function setupAddCustomerBtn() {
    document.querySelector('#add-btn2').addEventListener('click', function (e) {
        e.preventDefault();
        // Retrieve input values
        var firstName = document.getElementById('First_Name').value;
        var lastName = document.getElementById('Last_Name').value;
        var email = document.getElementById('Email').value;
        var contact = document.getElementById('Phone_Number').value;
        var address = document.getElementById('Address').value;

        var addedCustomerData = {
            Customer_ID: "",
            First_Name: firstName,
            Last_Name: lastName,
            Email: email,
            Phone_Number: contact,
            Address: address
        };

        // Assuming isError is defined somewhere in your code
        if (isError == false) {
            addCustomerFormSendData(addedCustomerData);
            addCustomerPopupOverlay.remove();
        }

        // Handle exit from edit
    });

    // Remove the edit pop-up without submitting
    document.getElementById('exitPopup').addEventListener('click', function () {
        addCustomerPopupOverlay.remove();
    });
}*/


        


/*function addCustomerFormSendData(addedCustomerData) {
    fetch('/Home/AddCustomer', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(addedCustomerData)
    })
        .then(data => {
            location.reload();
            console.log('Customer added successfully:', data);
            // Optionally, perform actions after successful customer addition
        })
        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
}*/