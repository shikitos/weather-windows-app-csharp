using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class LoginPage : UserControl
    {
        UserHistoryManager historyManager = UserHistoryManager.Instance;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ShowRegisterFormButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] controlsToShow = { MainForm.Instance.HeaderComponent, MainForm.Instance.RegisterPage };
            Control[] currentView = ViewController.GetCurrentView();
            ViewController.ShowView(controlsToShow);
            historyManager.PushToHistory(currentView);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void submitFormButton_Click(object sender, EventArgs e)
        {

        }

        private void LogginButtonContainer_Click(object sender, EventArgs e)
        {
            DatabaseController dbController = MainForm.Instance.DatabaseController;
            string username = inputUsernameLogin.Text;
            string password = inputPasswordLogin.Text;

            bool isLoggedIn = dbController.LoginUser(username, password);
            if (isLoggedIn)
            {
                Control Header = MainForm.Instance.HeaderComponent;
                Control[] controlsToShow = { Header, MainForm.Instance.HomePage };
                ViewController.ShowView(controlsToShow);
                historyManager.ClearHistory();
                MainForm.Instance.HeaderComponent.ModifyUserField(username);
                MainForm.Instance.HomePage.UserLoggedIn();

                Auth auth = MainForm.Instance.Auth;
                auth.Username = username;
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }
    }
}
