# Sample-C-Form-with-Buttons-SQL-Connected-to-the-Database

### C# Forms and Functionality Documentation

Form 1: Login Interface

Buttons and Functions:

Login Button – Handles user authentication.

Reset Button – Clears the entered credentials.

Exit Button – Closes the application.

Form 2: Students Info & Logout Window

Buttons and Functions:

Studen info Button – Access to the data management form.

LogOut Button – Goes back to the login form.


Form 3: Data Management System

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
