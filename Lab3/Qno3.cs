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

                // Insert Operation
                string insert = "INSERT INTO Employees (Name, Salary, Address) VALUES (@Name, @Salary, @Address)";
                using (SqlCommand insertCmd = new SqlCommand(insert, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Name", "Aaditya");
                    insertCmd.Parameters.AddWithValue("@Salary", 60000);
                    insertCmd.Parameters.AddWithValue("@Address", "Kathmandu");

                    int rowsInserted = insertCmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsInserted} row(s) inserted.");
                }

                // Select Operation
                string select = "SELECT * FROM Employees";
                using (SqlCommand selectCmd = new SqlCommand(select, conn))
                {
                    SqlDataReader reader = selectCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["ID"]}, Name: {reader["Name"]}, Salary: {reader["Salary"]}, Address: {reader["Address"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}