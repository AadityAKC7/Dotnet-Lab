using System;
using System.Data.SqlClient;

class Program
{
    // Connection string to connect to the database
    static string connectionString = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password";

    static void Main(string[] args)
    {
        // Get tour destination details from the user
        Console.Write("Enter Tour Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Tour Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Duration (in days): ");
        int duration = Convert.ToInt32(Console.ReadLine());

        // Call method to save the information
        SaveTourDestination(title, description, duration);
    }

    // Method to save tour destination information
    static void SaveTourDestination(string title, string description, int duration)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            // Insert query to add a new record into the TourDestination table
            string insertQuery = "INSERT INTO TourDestination (Title, Description, Duration, CreatedDate) VALUES (@Title, @Description, @Duration, @CreatedDate)";
            
            SqlCommand cmd = new SqlCommand(insertQuery, conn);

            // Adding parameters to avoid SQL injection
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@Duration", duration);
            cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

            try
            {
                // Open the database connection
                conn.Open();

                // Execute the query and get the number of rows affected
                int rowsInserted = cmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                {
                    Console.WriteLine("Tour destination saved successfully.");
                }
                else
                {
                    Console.WriteLine("Error: Tour destination could not be saved.");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur during execution
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}