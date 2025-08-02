# Mini ATM Project Detailed Documentation 💰✨

## 1. Project Name

Mini ATM 🏧

## 2. Overview

The Mini ATM project is a C# Windows Forms-based desktop application that allows users to securely access their accounts and perform basic banking transactions (withdrawals, deposits, transfers, bill payments), as well as easily update their personal information (name, surname, phone, password). 💻 This project aims to simulate an ATM experience for financial transactions and personal information management through its user-friendly interface, while providing a seamless user experience with comprehensive error handling and informative messages. 🎯

## 3. Technology Stack

* **Programming Language:** C# 🚀
* **UI Framework:** Windows Forms (WinForms) 🎨
* **Data Storage:** MS SQL Server (Special configurations are required for database connection. Please refer to Section "7. Setup Notes" for details.) 🗄️

## 4. Modules and Functions 🛠️

The project consists of the following main modules, allowing users to perform various banking operations and account management functions:

### 4.1. Login Module 🚪

* **Screen Name:** Login Screen
* **Description:** Allows users to securely log in to the system using their registered phone number and password.
* **Functionality:**
    * Input fields for phone number and password.
    * "Login" button: Initiates the user authentication process.
    * "Register" link: Directs new users to the Registration Screen to create an account.
* **Flowchart and Code Details:**
    * **Login Flow:** When the user clicks the `btnGirisYap` (Login) button, the entered phone number and password are used to search for a record in the database. If a record is found, the `Komutlar.GirisYap(Telefon)` method is called to transfer user information to the `Kisi` (Person) class, a "Login successful!" message is displayed, and the user is directed to the Main Menu. Otherwise, a "No user found with these credentials..." warning is given.
    * **`GirisYap` Method:** Retrieves all user information (`ID`, `Ad` (Name), `Soyad` (Surname), `Sifre` (Password), `Telefon` (Phone), `Bakiye` (Balance)) from the database using the provided phone number and assigns them to the static properties of the `Kisi` class. This ensures easy access to user information throughout the application.

### 4.2. Registration Module 📝

* **Screen Name:** Registration Screen
* **Description:** Enables new users to register and create an account in the system.
* **Functionality:**
    * Input fields for "Name", "Surname", "Password", and "Phone" information.
    * Password field includes a show/hide password ("eye" icon) feature.
    * "Register" button: Creates a new user account using the entered information.
    * "Login" link: Allows the user to return to the Login Screen after registration or if they change their mind.
* **Flowchart and Code Details:**
    * **Phone Number Validation:** Before the registration process, the entered phone number is validated using the `Telefon Hata Kontrol` (Phone Error Control) method. This method checks if the number is numeric, starts with "05", and is 11 digits long. Additionally, the `TekrarKontrol` (Duplicate Check) method verifies if the phone number is already registered in the system.
    * **`TekrarKontrol` Method:** Queries the database to check if the given phone number already exists. Returns `True` if a record is found, otherwise `False`. This plays a critical role in ensuring unique phone numbers for registration.
    * **`Telefon Hata Kontrol` Method:** A comprehensive validation method that checks the phone number's format (numeric, starts with "05", 11-digit length) and uniqueness. In case of any error, it displays the relevant warning message and returns `True`, preventing the operation.

### 4.3. Main Menu Module 🏠

* **Screen Name:** Menu
* **Description:** This is the main control panel the user accesses after logging in. All core banking and account management functions of the application can be accessed from here.
* **Functionality:**
    * Six main clickable buttons/cards offering transaction options: "Withdraw", "Deposit", "Transfer", "Bill Payment", "Update Information", "About".
    * Each button provides direct navigation to the respective transaction screen.

### 4.4. Withdrawal Module 💸

* **Screen Name:** Withdrawal Transaction
* **Description:** Allows the user to withdraw specified or manually entered amounts of cash from their own account.
* **Functionality:**
    * **Pre-defined Amount Buttons:** Pre-set options like 10 TL, 20 TL, 50 TL, 100 TL, 200 TL, 500 TL for quick and easy transactions.
    * **Manual Input:** A text field for the user to enter a different desired amount and a "Withdraw TL" button.
    * "Click to go to menu." link: Allows the user to cancel the operation and return to the Main Menu.
* **Flowchart and Code Details:**
    * **Withdrawal Flow:** When the `btnCek` (Withdraw) button is clicked, it first checks if the entered amount is numeric. If the amount is valid and the user has sufficient balance, the `ParaCek(Tutar)` (WithdrawMoney(Amount)) method is called.
    * **`ParaCek` Method:** Updates the user's balance in the database (`Kisi.Bakiye - Amount`). Upon successful completion, a confirmation message is displayed with the withdrawn amount and new balance ("Withdrawal successful! You withdrew [Withdrawn Amount] TL and you have [New Balance] TL left in your account.").
    * **Error Handling:** Relevant warning messages are displayed for invalid amount input or insufficient balance ("Please enter a valid amount.", "You don't have enough money, the transaction has been cancelled.").

### 4.5. Deposit Module 💰

* **Screen Name:** Deposit Screen
* **Description:** Allows the user to deposit cash into their own account.
* **Functionality:**
    * A text field to enter the amount to be deposited.
    * "Deposit TL" button: Initiates the deposit transaction.
* **Flowchart and Code Details:**
    * **Deposit Flow:** When the `btnYatir` (Deposit) button is clicked, it checks if the entered amount is numeric. If a valid amount is entered, the user's balance is increased in the database (`Kisi.Bakiye + Amount`).
    * **Successful Deposit:** A message confirms the transaction and provides the updated balance ("Deposit successful! You deposited [Deposited Amount] TL and now you have [New Balance] TL in your account!"). An "Please enter a valid amount." warning is given for invalid input.

### 4.6. Transfer Module ➡️💸

* **Screen Name:** Transfer Screen
* **Description:** Allows users to transfer money (havale) to another registered person in the system.
* **Functionality:**
    * Input fields for the recipient's "Name", "Surname", and "Phone number".
    * Input field for the amount to be sent.
    * "Send TL" button: Initiates the transfer transaction.
* **Flowchart and Code Details:**
    * **Transfer Flow:** When the `btnGonder` (Send) button is clicked, the recipient's details are first validated using the `Bakiye` (Balance) method. If the recipient is not found or the user attempts to transfer money to themselves (checked by the `BireyselHavaleKontrol` (Individual Transfer Control) method), an error status (`Hata` variable) becomes `true`. Subsequently, it checks if the transfer amount is numeric and if the sender has sufficient balance. If all checks pass, the `Havale(Amount)` method is called to execute the transaction.
    * **`Bakiye` Method:** Returns the balance of the user with the specified name, surname, and phone number. If the user is not found, it returns `-1`.
    * **`BireyselHavaleKontrol` Method:** Prevents users from transferring money to themselves. If such an attempt occurs, the user is offered the option to deposit money into their own account, and `True` is returned, cancelling the transfer.
    * **Error Handling:** Detailed warning messages are provided for "User not found.", "You don't have enough money...", "Please enter a valid balance." and other error conditions.

### 4.7. Bill Payment Module 🧾

* **Screen Name:** Bill Payment Screen
* **Description:** Allows users to select specific bill types and pay them from their accounts.
* **Functionality:**
    * A dropdown list under the "Select Bill Type." heading, containing bill types like "Electricity", "Water", "Gas".
    * (Although not explicitly shown in the images, the transaction assumes a fixed amount of `50 TL` for the selected bill type.)
    * "Pay" button: Initiates the bill payment process.
* **Flowchart and Code Details:**
    * **Bill Payment Flow:** When the `btnOde` (Pay) button is clicked, it first checks if a bill type has been selected. If a selection is made and the user has sufficient balance, the user's balance is updated in the database (`Kisi.Bakiye - 50`).
    * **Error Handling:** Protection against erroneous transactions is provided with warning messages like "Please select a bill type." and "You don't have enough money to pay your bill.".
    * **Successful Payment:** A message confirming the transaction and providing the updated balance is presented to the user ("Bill payment successful! You have [Remaining Balance] TL left in your account!").

### 4.8. Information Update Module 🔄

* **Screen Name:** Information Update Screen
* **Description:** Allows users to securely update their personal information (Name, Surname, Phone, Password).
* **Functionality:**
    * A dropdown list under the "Information to Update?" heading, containing updateable information types ("Name", "Surname", "Phone", "Password").
    * The relevant update screen opens based on the selected information type.
* **Flowchart and Code Details:**
    * **`Guncelle` Method:** This generic method (`public void Guncelle(string Tag, string NewText, string OldText)`) updates the specified `Tag` (column name) in the `Kisi` table in the database with `NewText`, targeting the record with the `OldText` value. This method is used in most basic information update operations.
    * **Name Update:** Calls `Komutlar.Guncelle("ad", txtAd.Text, Kisi.Ad)` and updates `Kisi.Ad` locally. Confirmation message: "Your name has been successfully updated! Your old name: [Old Name] Your new name is: [New Name]".
    * **Surname Update:** Calls `Komutlar.Guncelle("soyad", txtSoyad.Text, Kisi.Soyad)` and updates `Kisi.Soyad` locally. Confirmation message: "Your surname has been successfully updated! Your old surname: [Old Surname] Your new surname is: [New Surname]".
    * **Phone Update:** Before the update, the `Telefon Hata Kontrol` method checks the validity (format, length, uniqueness) of the new phone number. If there is no error, `Komutlar.Guncelle("telefon", txtTelefon.Text, Kisi.Telefon)` is called, and `Kisi.Telefon` is updated locally. Confirmation message: "Your phone number has been successfully updated! Your old phone number: [Old Phone] Your new phone number is: [New Phone]".
    * **Password Update:** Calls `Komutlar.Guncelle("sifre", txtSifre.Text, Kisi.Sifre)` and updates `Kisi.Sifre` locally. Confirmation message: "Your password has been successfully updated!".

### 4.9. About Module ℹ️

* **Screen Name:** About
* **Description:** Provides basic information about the application's developer.
* **Functionality:** Displays developer's Name (Semanur), Surname (Ağı), and reference number (B2080.010006).

## 5. User Interface (UI) and Experience (UX) Notes ✨

* The application adopts a modern and clean design with a dark theme and white/light-colored cards/buttons. 🌑⚪
* Font choices and sizes enhance text readability. 📖
* Error and confirmation messages are clearly communicated to the user via pop-up windows. 💬
* Small details like the ability to show/hide password visibility improve the user experience. 👁️‍🗨️
* Navigation (Return to Menu, Redirect to Login Screen) facilitates user flow. 🧭

## 6. Security and Validation General Notes 🛡️

* The application has basic user authentication mechanisms for both login and registration.
* Field-level validations, such as phone number format and uniqueness, are implemented.
* Financial transaction validations, like insufficient balance, prevent erroneous operations.
* Passwords, as inferred from the visuals, are masked (hidden).
* Parameters are used for database operations to prevent security vulnerabilities like SQL Injection.

## 7. Setup Notes ⚙️ (IMPORTANT! 🚨)

To run the program, you need to follow these steps:

1.  **Database Setup:** 💾
    * Navigate to the "Veritabanı dosyası" (Database file) folder within your project directory.
    * Locate the SQL script file appropriate for your MSSQL version (indicated by `mssql` in its name).
    * Execute this script in your SQL Server (e.g., using SQL Server Management Studio). This will create the necessary database and tables for the application.
2.  **Connection String Update:** 🔗
    * Open the "SqlBaglantisi" class within the program (typically found in a file like `Baglanti.cs` or similar).
    * Replace the existing connection string within this class with your own SQL Server connection string. This will enable the application to connect to your database correctly.

Once these steps are completed, your Mini ATM application will be ready to run smoothly! 💪
