using Npgsql;
using System;
using System.Collections.Generic;
using WeatherApp;

public class DatabaseController : IDisposable
{
    private readonly NpgsqlConnection connection;

    public DatabaseController(string connectionString)
    {
        connection = new NpgsqlConnection(connectionString);
        connection.Open();
    }

    public NpgsqlConnection Connect()
    {
        return connection;
    }

    public bool IsConnected()
    {
        try
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return false;
        }
    }

    public void Dispose()
    {
        connection.Close();
        connection.Dispose();
    }

    public bool RegisterUser(string username, string password)
    {
        var command = new NpgsqlCommand("INSERT INTO Users (user_username, user_password) VALUES (@username, @password)", connection);
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@password", password);

        try
        {
            command.ExecuteNonQuery();
            return true;
        }
        catch (NpgsqlException ex)
        {
            Console.WriteLine("Database error: " + ex.Message);
            return false;
        }
    }

    public bool LoginUser(string username, string password)
    {
        var command = new NpgsqlCommand("SELECT * FROM Users WHERE user_username = @username", connection);
        command.Parameters.AddWithValue("@username", username);

        try
        {
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string storedHash = reader.GetString(reader.GetOrdinal("user_password"));
                    return BCrypt.Net.BCrypt.Verify(password, storedHash);
                }
            }
            return false;
        }
        catch (NpgsqlException ex)
        {
            Console.WriteLine("Database error: " + ex.Message);
            return false;
        }
    }

    public List<User> GetUsers()
    {
        List<User> userList = new List<User>();

        var command = new NpgsqlCommand("SELECT * FROM Users", connection);

        try
        {
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                User user = new User
                {
                    Id = reader.GetInt32(reader.GetOrdinal("user_id")),
                    Username = reader.GetString(reader.GetOrdinal("user_username")),
                };

                userList.Add(user);
            }

            reader.Close();
        }
        catch (NpgsqlException ex)
        {
            Console.WriteLine("Database error: " + ex.Message);
        }

        return userList;
    }

}
