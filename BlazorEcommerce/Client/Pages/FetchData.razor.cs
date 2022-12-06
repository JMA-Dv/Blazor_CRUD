using BlazorEcommerce.Shared;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
namespace BlazorEcommerce.Client.Pages
{
    public partial class FetchData
    {
        [Inject]
        public HttpClient http { get; set; }

        private WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
