using Npgsql;
using System;
using System.Collections.Generic;

namespace WeatherApp
{
    internal class HistoryController
    {
        private readonly NpgsqlConnection connection;
        private readonly UserController userController;

        public HistoryController(NpgsqlConnection npgsqlConnection) {
            connection = npgsqlConnection;
        }

        public bool PutHistory(
        string username,
        string location,
        double temperature,
        string conditions
    )
        {
            int userId = userController.FindUser(username);

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
}
