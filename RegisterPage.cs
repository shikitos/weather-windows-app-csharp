using System;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class RegisterPage : UserControl
    {
        UserHistoryManager historyManager = UserHistoryManager.Instance;
        private readonly DatabaseController dbController;
        private readonly UserController userController;

        public RegisterPage()
        {
            InitializeComponent();
            dbController = new DatabaseController();
            userController = new UserController(dbController.Connect());
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
            string username = inputUsernameRegister.Text;
            string password = inputPasswordRegister.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            if (userController.FindUser(username) > 0)
            {
                MessageBox.Show("User with that username already exists");
                return;
            }

            bool isRegistered = userController.RegisterUser(username, hashedPassword);
            if (isRegistered)
            {
                MessageBox.Show("Registered successfully!");
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
            dbController.Dispose();
        }
    }
}
