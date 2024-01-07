using System;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class LoginPage : UserControl
    {
        readonly ViewHistoryManager historyManager = ViewHistoryManager.Instance;
        private UserController _userController;
        private DatabaseController _dbController;
        private readonly MainForm _mainForm;
        public LoginPage(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ShowRegisterFormButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] controlsToShow = { _mainForm.HeaderComponent, _mainForm.RegisterPage };
            Control[] currentView = ViewController.GetCurrentView();
            ViewController.ShowView(controlsToShow);
            historyManager.PushToHistory(currentView);
        }

        private void LogginButtonContainer_Click(object sender, EventArgs e)
        {
            _dbController = new DatabaseController();
            _userController = new UserController(_dbController.GetConnect());

            string username = inputUsernameLogin.Text;
            string password = inputPasswordLogin.Text;

            bool isLoggedIn = _userController.LoginUser(username, password);
            if (isLoggedIn)
            {
                Control Header = _mainForm.HeaderComponent;
                Control[] controlsToShow = { Header, _mainForm.HomePage };
                ViewController.ShowView(controlsToShow);
                historyManager.ClearHistory();
                _mainForm.HeaderComponent.ModifyUserField(username);
                _mainForm.HomePage.UserLoggedIn();

                Auth auth = _mainForm.Auth;
                auth.Username = username;
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }

            _userController.Dispose();
            _dbController.Dispose();
        }
    }
}
