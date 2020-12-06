using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static BlazorApp5.Pages.FetchData;

namespace BlazorApp5
{
    public class WeatherForecastClient
    {
        private readonly HttpClient client;

        public WeatherForecastClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            var forecasts = new WeatherForecast[0];

            try
            {
                forecasts = await client.GetFromJsonAsync<WeatherForecast[]>(
                    "sample-data/weather.json");
            }
            catch
            {

            }

            return forecasts;
        }
    }
}
