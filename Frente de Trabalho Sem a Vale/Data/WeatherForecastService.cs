
using Frente_de_Trabalho_Sem_a_Vale.Data.Extention;
using ModelShared;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Frente_de_Trabalho_Sem_a_Vale.Data
{
    public  class WeatherForecastService
    {
    
       
        public async Task<WeatherForecast[]> GetWeatherForecastAsync()
        {
            HttpClient httpClient = new HttpClient();
            WeatherForecast[] Weathers = default(WeatherForecast[]);
            HttpResponseMessage httpResponse = await httpClient.GetAsync("https://localhost:44330/weatherforecast");
            Weathers = await httpResponse.Content.ReadAsJsonAsync<WeatherForecast[]>();

            return Weathers;
        }


    }
}
