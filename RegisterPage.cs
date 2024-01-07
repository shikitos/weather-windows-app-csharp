using System;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class RegisterPage : UserControl
    {
        readonly ViewHistoryManager historyManager = ViewHistoryManager.Instance;
        private readonly DatabaseController _dbController;
        private readonly UserController _userController;
        private readonly MainForm _mainForm;


        public RegisterPage(MainForm mainForm)
        {
            InitializeComponent();
            _dbController = new DatabaseController();
            _userController = new UserController(_dbController.GetConnect());
            _mainForm = mainForm;
        }

        private void ShowLoginPageButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] controlsToShow = { _mainForm.HeaderComponent, _mainForm.LoginPage };
            Control[] currentView = ViewController.GetCurrentView();
            ViewController.ShowView(controlsToShow);
            historyManager.PushToHistory(currentView);
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = inputUsernameRegister.Text;
            string password = inputPasswordRegister.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            if (_userController.FindUser(username) > 0)
            {
                MessageBox.Show("User with that username already exists");
                return;
            }

            bool isRegistered = _userController.RegisterUser(username, hashedPassword);
            if (isRegistered)
            {
                MessageBox.Show("Registered successfully!");
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
            _dbController.Dispose();
        }
    }
}
