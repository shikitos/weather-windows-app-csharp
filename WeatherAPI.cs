using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;
using Newtonsoft.Json;

public class WeatherAPI
{
    private readonly string apiKey;
    private readonly string baseUrl;

    public WeatherAPI()
    {
        apiKey = Environment.GetEnvironmentVariable("API_KEY");
        baseUrl = Environment.GetEnvironmentVariable("BASE_URL");
    }

    public async Task<WeatherResponse> GetWeatherAsync(string city, int days)
    {
        using (HttpClient client = new HttpClient())
        {
            string url = $"{baseUrl}forecast.json?key={apiKey}&q={city}&days={days}";
            Debug.WriteLine("Request URL: " + url);

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseBody);
                return weatherResponse;
            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine("Error fetching weather data: " + e.Message);
                throw;
            }
        }
    }
}
