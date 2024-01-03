using System;
using System.Configuration;
using System.Windows.Forms;
using dotenv.net;

namespace WeatherApp
{
    internal static class Program
    {
        private static readonly string DBServerAddress;
        private static readonly string DBPort;
        private static readonly string DBUsername;
        private static readonly string DBPassword;

        static Program()
        {
            DotEnv.Load(options: new DotEnvOptions(ignoreExceptions: false, envFilePaths: new[] { ".env" }));

            DBServerAddress = Environment.GetEnvironmentVariable("DB_ADDRESS");
            DBPort = Environment.GetEnvironmentVariable("DB_PORT");
            DBUsername = Environment.GetEnvironmentVariable("DB_USERNAME");
            DBPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
        }

        [STAThread]
        static void Main()
        {
            if (string.IsNullOrEmpty(DBServerAddress) || string.IsNullOrEmpty(DBPort) || string.IsNullOrEmpty(DBUsername) || string.IsNullOrEmpty(DBPassword))
            {
                MessageBox.Show(
                    $"Please set environment variables for database configuration.\n" +
                    $"DBServerAddress: {DBServerAddress ?? "Not found"}\n" +
                    $"DBPort: {DBPort ?? "Not found"}\n" +
                    $"DBUsername: {DBUsername ?? "Not found"}\n" +
                    $"DBPassword: {DBPassword ?? "Not found"}.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }


            string connectionString = $"Server={DBServerAddress};Port={DBPort};User Id={DBUsername};Password={DBPassword};";

            using (DatabaseController dbController = new DatabaseController(connectionString))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(dbController));
            }
        }
    }
}
