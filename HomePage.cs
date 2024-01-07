using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class HomePage : UserControl
    {
        private readonly WeatherAPI weatherApi;
        private static LinkLabel historyLink;
        private DatabaseController dbController;
        private bool isRegistered = false;
        private HistoryController historyController;
        Auth auth;

        public HomePage()
        {
            InitializeComponent();
            labelsGroupPanel.Visible = false;
            weatherApi = new WeatherAPI();

            input.KeyDown += Input_KeyDown;
            outputField.Text = "";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            FetchWeatherData();
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FetchWeatherData();
            }
        }

        private async void FetchWeatherData()
        {
            string place = input.Text;
            if (!string.IsNullOrWhiteSpace(place))
            {
                try
                {
                    WeatherResponse weatherJson = await weatherApi.GetWeatherAsync(place, 3);

                    string weatherDescription = weatherJson.Current.Condition.Text;
                    double temperatureCelsius = weatherJson.Current.Temp_C;

                    string weatherMotto = GetWeatherMotto(place, weatherDescription);

                    Debug.WriteLine("weatherJson.Location.Localtime", weatherJson.Location.Localtime);
                    /*outputField.Text = $"Current Weather in {place}:\n" +
                                      $"- Condition: {weatherDescription}\n" +
                                      $"- Temperature: {temperatureCelsius} °C\n" +
                                      $"{weatherMotto}";*/

                    cityLabel.Text = weatherJson.Location.Name;
                    temperatureLabel.Text = $"{temperatureCelsius} °";
                    conditionLabel.Text = $"{weatherDescription}";
                    labelsGroupPanel.Visible = true;

                    string imageName = WeatherControllerUtility.GetConditionImage(weatherJson.Current.Condition, weatherJson.Location.Localtime);
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Assets\Images\{imageName}");

                    if (File.Exists(imagePath))
                    {
                        Image backgroundImage = Image.FromFile(imagePath);
                        BackgroundImage = backgroundImage;
                        BackgroundImageLayout = ImageLayout.Stretch;
                    }

                    if (historyController != null && isRegistered)
                    {

                        dbController = new DatabaseController();
                        historyController.PutHistory(auth.Username, place, temperatureCelsius, weatherDescription);
                        dbController.Dispose();
                    }
                }
                catch (System.Net.WebException webEx)
                {
                    outputField.Text = "Network error: " + webEx.Message;
                    Debug.WriteLine("Network error: " + webEx.Message);
                }
                catch (Exception ex)
                {
                    outputField.Text = "Error: " + ex.Message;
                    Debug.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Debug.WriteLine("Please enter a valid city name");
                outputField.Text = "Please enter a valid city name";
            }
        }

        string GetWeatherMotto(string place, string weatherDescription)
        {
            string motto;

            if (weatherDescription.Contains("rain"))
            {
                motto = $"☔ Don't forget your umbrella when visiting {place}!";
            }
            else if (weatherDescription.Contains("sunny"))
            {
                motto = $"🌞 Enjoy the sunny weather in {place}!";
            }
            else
            {
                motto = $"Explore the unique weather in {place}!";
            }

            return motto;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            /*if (outputField.Text.Length > 0)
            {
                outputField.Text = "";
            }*/
        }

        private void HistoryLabel_LinkClicked(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(auth.Username);
            historyForm.Show();
        }

        public void UserLoggedIn()
        {
            historyLink = new LinkLabel
            {
                Location = new Point(2, 80),
                Cursor = Cursors.Hand,
                Text = "History",
                BackColor = Color.Transparent,
            };

            Controls.Add(historyLink);
            historyLink.Click += HistoryLabel_LinkClicked;
            dbController = new DatabaseController();
            historyController = new HistoryController(dbController.Connect());
            isRegistered = true;
            auth = MainForm.Instance.Auth;
            dbController.Dispose();
        }

    }
}
