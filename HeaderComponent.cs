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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WeatherApp
{
    public partial class HeaderComponent : UserControl
    {
        UserHistoryManager historyManager = UserHistoryManager.Instance;

        public HeaderComponent()
        {
            InitializeComponent();
            authButton.Click += AuthButton_Click;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Auth auth = MainForm.Instance.Auth;
            auth.Username = "";

            ViewController.ShowView(new Control[] { MainForm.Instance.WelcomePage });
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
            Control[] controlsToShow = { MainForm.Instance.HeaderComponent, MainForm.Instance.LoginPage };
            Control[] currentView = ViewController.GetCurrentView();
            ViewController.ShowView(controlsToShow);
            historyManager.PushToHistory(currentView);
        }

        private void Back_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (historyManager.GetUserHistoryLength > 0)
            {
                Control[] lastView = historyManager.PopFromHistory();
                Debug.WriteLine($"Go back, stack data count: {historyManager.GetUserHistoryLength}, retrieved components {lastView.Length}");
                ViewController.ShowView(lastView);
            }
            else
            {
                Debug.WriteLine($"History is empty: { historyManager.GetUserHistoryLength}");
            }

            UpdateBackButtonVisibility();
        }
    }
}
