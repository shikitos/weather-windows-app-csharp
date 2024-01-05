using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WelcomePage : UserControl
    {
        private readonly UserHistoryManager historyManager = UserHistoryManager.Instance;
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] currentView = ViewController.GetCurrentView();
            historyManager.PushToHistory(currentView);

            Control[] controlsToShow = { MainForm.Instance.HeaderComponent, MainForm.Instance.LoginPage }; 
            ViewController.ShowView(controlsToShow);
        }


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Control[] controlsToShow = { MainForm.Instance.HeaderComponent, MainForm.Instance.HomePage };
            ViewController.ShowView(controlsToShow);
            MainForm.Instance.HeaderComponent.UpdateBackButtonVisibility(false);
        }
    }
}
