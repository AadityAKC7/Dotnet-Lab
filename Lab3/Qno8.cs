using System;
using System.Data.SqlClient;

class Program
{
    // Connection string to connect to the database
    static string connection = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password";

    static void Main(string[] args)
    {
        // Call CRUD operations
        CreateEmployee("Aaditya", 60000, "Kathmandu");
        ReadEmployees();
        UpdateEmployee(1, "Aaditya Updated", 65000, "Lalitpur");
        ReadEmployees();
        DeleteEmployee(1);
        ReadEmployees();
    }

    // CREATE Operation
    static void CreateEmployee(string name, decimal salary, string address)
    {
        using (SqlConnection conn = new SqlConnection(connection))
        {
            string insertQuery = "INSERT INTO Employees (Name, Salary, Address) VALUES (@Name, @Salary, @Address)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Address", address);

            try
            {
                conn.Open();
                int rowsInserted = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsInserted} row(s) inserted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    // READ Operation
    static void ReadEmployees()
    {
        using (SqlConnection conn = new SqlConnection(connection))
        {
            string selectQuery = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(selectQuery, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Employees:");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["ID"]}, Name: {reader["Name"]}, Salary: {reader["Salary"]}, Address: {reader["Address"]}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    // UPDATE Operation
    static void UpdateEmployee(int id, string name, decimal salary, string address)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string updateQuery = "UPDATE Employees SET Name = @Name, Salary = @Salary, Address = @Address WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Address", address);

            try
            {
                conn.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsUpdated} row(s) updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    // DELETE Operation
    static void DeleteEmployee(int id)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string deleteQuery = "DELETE FROM Employees WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(deleteQuery, conn);
            cmd.Parameters.AddWithValue("@ID", id);

            try
            {
                conn.Open();
                int rowsDeleted = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsDeleted} row(s) deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}