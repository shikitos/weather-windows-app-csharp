using CefSharp.DevTools.Debugger;
using Npgsql;
using System;
using System.Collections.Generic;
using WeatherApp;

public class DatabaseController : IDisposable
{
    private readonly NpgsqlConnection connection;

    private readonly string DBServerAddress;
    private readonly string DBPort;
    private readonly string DBUsername;
    private readonly string DBPassword;

    public DatabaseController()
    {
        DBServerAddress = Environment.GetEnvironmentVariable("DB_ADDRESS");
        DBPort = Environment.GetEnvironmentVariable("DB_PORT");
        DBUsername = Environment.GetEnvironmentVariable("DB_USERNAME");
        DBPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
        string connectionString = $"Server={DBServerAddress};Port={DBPort};User Id={DBUsername};Password={DBPassword};";


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

}
