// See https://aka.ms/new-console-template for more information

using MySql.Data.MySqlClient;

string connectionString = "Server=localhost;Port=3306;Database=testing;User ID=root;Password=example;SslMode=None;";
using (MySqlConnection connection = new MySqlConnection(connectionString))
{
    try
    {
        connection.Open();
        string query = "SELECT * FROM testing1";
        using (MySqlCommand command = new MySqlCommand(query, connection))
        {
            var result =await command.ExecuteReaderAsync();
            Console.WriteLine($"Query Result: {result}");
        }
        Console.WriteLine("Connected to the database!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}