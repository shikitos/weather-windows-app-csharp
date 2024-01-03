using System;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class RegisterPage : UserControl
    {
        UserHistoryManager historyManager = UserHistoryManager.Instance;

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void ShowLoginPageButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] controlsToShow = { MainForm.Instance.HeaderComponent, MainForm.Instance.LoginPage };
            Control[] currentView = ViewController.GetCurrentView();
            ViewController.ShowView(controlsToShow);
            historyManager.PushToHistory(currentView);
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            DatabaseController dbController = MainForm.Instance.DatabaseController;
            string username = inputUsernameRegister.Text;
            string password = inputPasswordRegister.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            bool isRegistered = dbController.RegisterUser(username, hashedPassword);
            if (isRegistered)
            {
                MessageBox.Show("Registered successfully!");
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }
    }
}
