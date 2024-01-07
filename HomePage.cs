using Npgsql;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class HomePage : UserControl
    {
        private readonly WeatherAPI _weatherApi;
        private static LinkLabel _historyLink;
        private DatabaseController _dbController;
        private HistoryController _historyController;
        private Auth _auth;
        private HistoryForm _historyForm;
        private bool _isLogged = false;

        private readonly MainForm _mainForm;

        public HomePage(MainForm mainForm)
        {
            InitializeComponent();
            labelsGroupPanel.Visible = false;
            _weatherApi = new WeatherAPI();

            input.KeyDown += Input_KeyDown;
            outputField.Text = "";
            _mainForm = mainForm;
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
            if (!ValidatePlace(place)) return;

            try
            {
                WeatherResponse weatherJson = await FetchWeather(place);
                UpdateUIWithWeatherData(weatherJson);
                LoadBackgroundImage(weatherJson);
                LogWeatherHistory(weatherJson);
            }
            catch (System.Net.WebException webEx)
            {
                Utils.HandleError(webEx, outputField);
            }
            catch (Exception ex)
            {
                Utils.HandleError(ex, outputField);
            }
        }

        private async Task<WeatherResponse> FetchWeather(string place)
        {
            return await _weatherApi.GetWeatherAsync(place, 1);
        }

        private bool ValidatePlace(string place)
        {
            if (!string.IsNullOrWhiteSpace(place)) return true;

            outputField.Text = "Please enter a valid city name";
            return false;
        }

        private void UpdateUIWithWeatherData(WeatherResponse weatherJson)
        {
            string weatherDescription = weatherJson.Current.Condition.Text;
            double temperatureCelsius = weatherJson.Current.Temp_C;
            string location = weatherJson.Location.Name;

            cityLabel.Text = location;
            temperatureLabel.Text = $"{temperatureCelsius} °C";
            conditionLabel.Text = weatherDescription;
            mottoLabel.Text = GetWeatherMotto(location, weatherDescription);
            outputField.Text = "";

            labelsGroupPanel.Visible = true;

        }

        private void LoadBackgroundImage(WeatherResponse weatherJson)
        {
            string imageName = WeatherControllerUtility.GetConditionImage(weatherJson.Current.Condition, weatherJson.Location.Localtime);
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"Assets\Images\{imageName}");

            if (File.Exists(imagePath))
            {
                Image backgroundImage = Image.FromFile(imagePath);
                BackgroundImage = backgroundImage;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void LogWeatherHistory(WeatherResponse weatherJson)
        {
            if (!_isLogged) return;

            _dbController = new DatabaseController();
            NpgsqlConnection connection = _dbController.GetConnect();
            _historyController = new HistoryController(connection);

            string place = weatherJson.Location.Name;
            double temperatureCelsius = weatherJson.Current.Temp_C;
            string weatherDescription = weatherJson.Current.Condition.Text;

            _historyController.PutHistory(_auth.Username, place, temperatureCelsius, weatherDescription);

            _historyController.Dispose();
            _dbController.Dispose();

            UpdateHistoryForm();
        }

        private void UpdateHistoryForm()
        {
            if (_historyForm != null && _historyForm.Visible)
            {
                _historyForm.PopulateHistoryListView();
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
                motto = $"🌪️ Explore the unique weather in {place}!";
            }

            return motto;
        }

        private void HistoryLabel_LinkClicked(object sender, EventArgs e)
        {
            _historyForm = new HistoryForm(_auth.Username);
            _historyForm.Show();
        }

        public void UserLoggedIn()
        {
            _historyLink = new LinkLabel
            {
                Location = new Point(2, 80),
                Cursor = Cursors.Hand,
                Text = "History",
                BackColor = Color.Transparent,
            };

            Controls.Add(_historyLink);
            _historyLink.Click += HistoryLabel_LinkClicked;
            _auth = _mainForm.Auth;
            _isLogged = true;
        }

    }
}
