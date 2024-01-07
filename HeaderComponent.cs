using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class HeaderComponent : UserControl
    {
        readonly UserHistoryManager historyManager = UserHistoryManager.Instance;
        private readonly MainForm _mainForm;

        public HeaderComponent(MainForm mainForm)
        {
            InitializeComponent();
            authButton.Click += AuthButton_Click;
            _mainForm = mainForm;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Auth auth = _mainForm.Auth;
            auth.Username = "";

            ViewController.ShowView(new Control[] { _mainForm.WelcomePage });
            ResetHeader();
        }

        public void UpdateBackButtonVisibility(bool forceUpdate = false)
        {
            backButton.Visible = forceUpdate || historyManager.GetUserHistoryLength > 0;
        }

        public void ModifyUserField(string username) {
            userNameLabel.Text = username;
            logoutButton.Visible = true;
            authButton.Visible = false;
        }

        public void HideAuthButtons()
        {
            logoutButton.Visible = false;
            authButton.Visible = false;
        }

        public void ShowAuthButtons()
        {
            logoutButton.Visible = false;
            authButton.Visible = true;
        }

        public void ResetHeader()
        {
            userNameLabel.Text = "";
            logoutButton.Visible = false;
            authButton.Visible = true;
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            Control[] controlsToShow = { _mainForm.HeaderComponent, _mainForm.LoginPage };
            Control[] currentView = ViewController.GetCurrentView();
            ViewController.ShowView(controlsToShow);
            historyManager.PushToHistory(currentView);
        }

        private void Back_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (historyManager.GetUserHistoryLength > 0)
            {
                Control[] lastView = historyManager.PopFromHistory();
                ViewController.ShowView(lastView);
            }

            UpdateBackButtonVisibility();
        }
    }
}
