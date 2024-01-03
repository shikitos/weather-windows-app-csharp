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

        public HomePage()
        {
            InitializeComponent();
            weatherApi = new WeatherAPI();

            // addEventListener for input
            input.KeyDown += Input_KeyDown;
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

                    outputField.Text = $"Current Weather in {place}:\n" +
                                      $"- Condition: {weatherDescription}\n" +
                                      $"- Temperature: {temperatureCelsius} °C\n" +
                                      $"{weatherMotto}";
                    string imageName = WeatherControllerUtility.GetConditionImage(weatherJson.Current.Condition, weatherJson.Location.Localtime_Epoch);
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Assets\Images\{imageName}");
                    Debug.WriteLine(imagePath);
                    Debug.WriteLine("File.Exists(imagePath)" + File.Exists(imagePath).ToString());
                    if (File.Exists(imagePath))
                    {
                        Image backgroundImage = Image.FromFile(imagePath);

                        BackgroundImage = backgroundImage;
                        BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                catch (System.Net.WebException webEx)
                {
                    outputField.Text = "Web Exception: " + webEx.Message;
                    Debug.WriteLine("Web Exception: " + webEx.Message);
                }
                catch (Exception ex)
                {
                    outputField.Text = "Error: " + ex.Message;
                }
            }
            else
            {
                outputField.Text = "Please enter a city name.";
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


        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
