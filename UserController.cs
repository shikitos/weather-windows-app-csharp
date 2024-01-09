using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WeatherApp
{
    public class UserController : IDisposable
    {
        private readonly NpgsqlConnection _connection;
        private bool _disposed = false;
        public UserController(NpgsqlConnection npgsqlConnection) {
            _connection = npgsqlConnection;
        }

        public int FindUser(string username)
        {
            var command = new NpgsqlCommand("SELECT * FROM Users WHERE user_username = @username", _connection);
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
                throw ex;
            }
        }


        public bool RegisterUser(string username, string password)
        {
            var insertCommand = new NpgsqlCommand("INSERT INTO Users (user_username, user_password) VALUES (@username, @password)", _connection);
            insertCommand.Parameters.AddWithValue("@username", username);
            insertCommand.Parameters.AddWithValue("@password", password);

            try
            {
                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
        }


        public bool LoginUser(string username, string password)
        {
            var command = new NpgsqlCommand("SELECT * FROM Users WHERE user_username = @username", _connection);
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
                throw ex;
            }
        }


        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();

            var command = new NpgsqlCommand("SELECT * FROM Users", _connection);

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
                throw ex;
            }

            return userList;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _connection?.Dispose();
                }


                _disposed = true;
            }
        }

        ~UserController()
        {
            Dispose(false);
        }

    }
}
