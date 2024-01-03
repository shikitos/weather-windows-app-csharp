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

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] currentView = ViewController.GetCurrentView();
            historyManager.PushToHistory(currentView);
            Debug.WriteLine("Saving current view, contains: " + currentView.Length);

            Control[] controlsToShow = { MainForm.Instance.HeaderComponent, MainForm.Instance.RegisterPage }; // Change LoginPage to RegisterPage
            ViewController.ShowView(controlsToShow);
            Debug.WriteLine("Navigated to Register Page");
        }


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Control[] controlsToShow = { MainForm.Instance.HeaderComponent, MainForm.Instance.HomePage };
            ViewController.ShowView(controlsToShow);
            MainForm.Instance.HeaderComponent.UpdateBackButtonVisibility(false);
        }
    }
}
