# Sample-C-Form-with-Buttons-SQL-Connected-to-the-Database

https://www.youtube.com/watch?v=cQ3zHDQbSpk
https://www.youtube.com/watch?v=5G0ptItFjSY

### C# Forms and Functionality Documentation

![Screenshot 2025-05-01 234306](https://github.com/user-attachments/assets/1d1f3359-5160-4dc0-878a-cde64d2cbf29)

Form 1: Login Interface

Buttons and Functions:

Login Button – Handles user authentication.

Reset Button – Clears the entered credentials.

Exit Button – Closes the application.

Form 2: Students Info & Logout Window

![Screenshot 2025-05-01 234333](https://github.com/user-attachments/assets/ffb5d0b0-1665-4581-80e3-8ce43aa1b134)

Buttons and Functions:

Student Info Button – Access to the data management form.

LogOut Button – Goes back to the login form.

Form 3: Data Management System

![Screenshot 2025-05-01 234404](https://github.com/user-attachments/assets/e05519fa-80f1-4550-9167-b85c949f39c4)

SQL Connection Setup:

Add using 

System.Data.SqlClient; for database connectivity.

Define the connection string:

SqlConnection con = new SqlConnection(@"your_connection_string_here");

Ensure connection is closed after use with abc.Close();.

Buttons and Functions:

Search Button – Retrieves student data from the database.

Save Button – Adds new records to the database.

Update Button – Modifies existing data.

Delete Button – Removes records.

Clear Button – Resets form fields.

Back Button – Navigates to the previous interface.

View Button – Displays stored records.

Navigation:

Form1 → Form3

Form3 → Form2

Form2 → Form3

Form3 → Form1
