using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WelcomePage : UserControl
    {
        private readonly UserHistoryManager historyManager = UserHistoryManager.Instance;
        private readonly MainForm _mainForm;
        public WelcomePage(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] currentView = ViewController.GetCurrentView();
            historyManager.PushToHistory(currentView);

            Control[] controlsToShow = { _mainForm.HeaderComponent, _mainForm.LoginPage }; 
            ViewController.ShowView(controlsToShow);
        }


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Control[] controlsToShow = { _mainForm.HeaderComponent, _mainForm.HomePage };
            ViewController.ShowView(controlsToShow);
            _mainForm.HeaderComponent.UpdateBackButtonVisibility(false);
        }
    }
}
