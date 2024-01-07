using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;

public class WeatherAPI
{
    private readonly string _apiKey;
    private readonly string _baseUrl;

    public WeatherAPI()
    {
        _apiKey = Environment.GetEnvironmentVariable("API_KEY");
        _baseUrl = Environment.GetEnvironmentVariable("BASE_URL");
    }

    public async Task<WeatherResponse> GetWeatherAsync(string city, int days)
    {
        using (HttpClient client = new HttpClient())
        {
            string url = $"{_baseUrl}forecast.json?key={_apiKey}&q={city}&days={days}";

            try
            {
                HttpResponseMessage response = await SendRequestAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseBody);
                return weatherResponse;
            }
            catch (HttpRequestException e)
            {
                if (e.Message.Contains("400"))
                {
                    throw new Exception("Invalid city name. Try again!");
                }
                else
                {
                    Debug.WriteLine("Error fetching weather data: " + e.Message);
                    throw;
                }
            }
        }
    }

    private async Task<HttpResponseMessage> SendRequestAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            return await client.GetAsync(url);
        }
    }
}
