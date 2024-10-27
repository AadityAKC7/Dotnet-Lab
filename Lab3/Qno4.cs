using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Connection string to connect to the database
        string connection = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password";

        using (SqlConnection conn = new SqlConnection(connection))
        {
            try
            {
                // Open the database connection
                conn.Open();

                // Update (Edit) Operation
                string updateQuery = "UPDATE Employees SET Salary = @Salary WHERE Name = @Name";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@Salary", 70000);
                    updateCmd.Parameters.AddWithValue("@Name", "Aaditya");

                    int rowsUpdated = updateCmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsUpdated} row(s) updated.");
                }

                // Delete Operation
                string deleteQuery = "DELETE FROM Employees WHERE Name = @Name";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@Name", "Aaditya");

                    int rowsDeleted = deleteCmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsDeleted} row(s) deleted.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}