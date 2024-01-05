using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WeatherApp
{
    internal class ViewController
    {
        public static void ShowView(Control[] controlsToShow)
        {
            if (MainForm.Instance == null || controlsToShow == null)
                throw new ArgumentNullException();

            bool shouldShowAuthButtons = true;
            foreach (Control control in MainForm.Instance.Controls)
            {
                bool isVisible = controlsToShow.Contains(control);
                control.Visible = isVisible;

                if (isVisible && (control == MainForm.Instance.RegisterPage || control == MainForm.Instance.LoginPage))
                {
                    shouldShowAuthButtons = false;
                }
            }

            if (shouldShowAuthButtons)
            {
                MainForm.Instance.HeaderComponent.ShowAuthButtons();
            }
            else
            {
                MainForm.Instance.HeaderComponent.HideAuthButtons();
            }
        }

        public static Control[] GetCurrentView()
        {
            if (MainForm.Instance != null)
            {
                List<Control> visibleControls = new List<Control>();

                foreach (Control control in MainForm.Instance.Controls)
                {
                    if (control.Visible)
                    {
                        visibleControls.Add(control);
                    }
                }

                return visibleControls.ToArray();
            }

            return new Control[0];
        }
    }
}
