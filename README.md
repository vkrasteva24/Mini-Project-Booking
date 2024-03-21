1. **Authentication Process:**
   - When a user attempts to log in, the application verifies their credentials against a SQL Server database.
   - The `AuthenticateUser` method in the `DatabaseManager` class executes a SQL query to check if a user with the provided username and password exists in the database.
   - If the credentials match, the method retrieves the user's name from the database.
   - If authentication is successful, the method returns a `Users` object containing the user's name.
   - If authentication fails, the method returns null, and an error message is displayed to the user.

2. **Main Application (Form1):**
   - After successful authentication, the user is redirected to the main application window (`Form1`).
   - The main application window allows users to filter restaurant reservations based on various criteria such as restaurant name, number of guests, and reservation time.
   - Users can also clear applied filters, book new reservations, and delete existing reservations.

3. **Booking Form (booking):**
   - Users can access the booking form from the main application window to make new reservations.
   - The booking form (`booking`) provides input fields for the guest's name, phone number, selected restaurant, table number, reservation time, and reservation type.
   - Upon clicking the "Book" button, the application checks the availability of the selected table in the database.
   - If the table is available, the application inserts the booking details into the database and updates the table's availability status.
   - Users receive a confirmation message upon successful booking.

4. **Delete Booking Form (delete):**
   - Users with appropriate permissions can access the delete booking form (`delete`) from the main application window.
   - The delete booking form displays existing reservations in a datagrid, allowing users to select a booking to delete.
   - Upon confirmation, the application deletes the selected booking from the database.

5. **Dependencies:**
   - The application relies on a SQL Server database for storing user credentials, restaurant reservations, and table availability information.
   - It uses ADO.NET for database connectivity and SQL queries execution.
   - The user interface is developed using Windows Forms in C#.
