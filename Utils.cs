using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WeatherApp
{
    public class Utils
    {
        public static void HandleError(Exception ex, Label outputLabel)
        {
            if (outputLabel != null)
            {
                if (ex is System.Net.WebException webEx)
                {
                    outputLabel.Text = "Network error: " + webEx.Message;
                }
                else
                {
                    outputLabel.Text = "Error: " + ex.Message;
                }
            }

            Debug.WriteLine("Error: " + ex.Message);
        }

    }
}
