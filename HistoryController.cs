using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WeatherApp
{
    internal class HistoryController : IDisposable
    {
        private readonly NpgsqlConnection _connection;
        private readonly UserController _userController;
        private bool _disposed = false;

        public HistoryController(NpgsqlConnection npgsqlConnection) {
            _connection = npgsqlConnection;
            _userController = new UserController(_connection);
        }

        public bool PutHistory(
            string username,
            string location,
            double temperature,
            string conditions
        )
        {
            int userId = _userController.FindUser(username);

            if (userId > 0)
            {
                try
                {
                    var command = new NpgsqlCommand("INSERT INTO History (history_user, location, temperature, conditions) VALUES (@userId, @location, @temperature, @conditions)", _connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@location", location);
                    command.Parameters.AddWithValue("@temperature", temperature);
                    command.Parameters.AddWithValue("@conditions", conditions);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully added to history: " + location);
                    return true;
                }
                catch (NpgsqlException ex)
                {
                    throw ex;
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
                var command = new NpgsqlCommand("SELECT h.* FROM History h INNER JOIN Users u ON h.history_user = u.user_id WHERE u.user_username = @username", _connection);

                command.Parameters.AddWithValue("@username", username);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string location = reader.GetString(reader.GetOrdinal("location"));
                        double temperature = reader.GetDouble(reader.GetOrdinal("temperature"));

                        string conditions = reader.GetString(reader.GetOrdinal("conditions"));

                        DateTime date = reader.GetDateTime(reader.GetOrdinal("date"));

                        HistoryRecord historyRecord = new HistoryRecord
                        {
                            Location = location,
                            Temperature = temperature,
                            Conditions = conditions,
                            Date = date
                        };

                        historyRecords.Add(historyRecord);
                    }
                }

                return historyRecords;
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
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

        ~HistoryController()
        {
            Dispose(false);
        }
    }
}
