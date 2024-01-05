using CefSharp.DevTools.Debugger;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WeatherApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

    public int FindUser(string username)
    {
        var command = new NpgsqlCommand("SELECT * FROM Users WHERE user_username = @username", connection);
        command.Parameters.AddWithValue("@username", username);

        try
        {
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    User user = new User
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("user_id")),
                        Username = reader.GetString(reader.GetOrdinal("user_username")),
                    };
                    return user.Id;
                }
                return -1;
            }
        }
        catch (NpgsqlException ex)
        {
            Console.WriteLine("Database error: " + ex.Message);
        }

        return -1;
    }


    public bool RegisterUser(string username, string password)
    {
        var insertCommand = new NpgsqlCommand("INSERT INTO Users (user_username, user_password) VALUES (@username, @password)", connection);
        insertCommand.Parameters.AddWithValue("@username", username);
        insertCommand.Parameters.AddWithValue("@password", password);

        try
        {
            insertCommand.ExecuteNonQuery();
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

    public bool PutHistory(
        string username, 
        string location,
        double temperature, 
        string conditions
    )
    {
        int userId = FindUser(username);

        if (userId > 0)
        {
            try
            {
                var command = new NpgsqlCommand("INSERT INTO History (history_user, location, temperature, conditions) VALUES (@userId, @location, @temperature, @conditions)", connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@temperature", temperature);
                command.Parameters.AddWithValue("@conditions", conditions);
                command.ExecuteNonQuery();
                return true;
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public List<HistoryRecord> GetHistoryByUsername(string username)
    {
        List<HistoryRecord> historyRecords = new List<HistoryRecord>();

        try
        {
            var command = new NpgsqlCommand("SELECT h.* FROM History h INNER JOIN Users u ON h.history_user = u.user_id WHERE u.user_username = @username", connection);

            command.Parameters.AddWithValue("@username", username);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string location = reader.GetString(reader.GetOrdinal("location"));
                    double temperature = reader.GetDouble(reader.GetOrdinal("temperature"));

                    string conditions = reader.GetString(reader.GetOrdinal("conditions"));

                    HistoryRecord historyRecord = new HistoryRecord
                    {
                        Location = location,
                        Temperature = temperature,
                        Conditions = conditions
                    };

                    historyRecords.Add(historyRecord);
                }
            }

            return historyRecords;
        }
        catch (NpgsqlException ex)
        {
            Console.WriteLine("Database error: " + ex.Message);
            return null;
        }
    }

}
