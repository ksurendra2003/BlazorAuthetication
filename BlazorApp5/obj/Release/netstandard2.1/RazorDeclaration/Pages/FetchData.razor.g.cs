// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using BlazorApp5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using BlazorApp5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
           [Microsoft.AspNetCore.Authorization.Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
       
    private bool isOpened = false;

    private WeatherForecast[] forecasts;

    private string WDate = string.Empty;
    private string WSummary = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            //forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");

            //var forecasts1 = await Http.GetStringAsync("WeatherForecast");

            forecasts = await WfClient.GetForecastAsync();


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

    private void OpenPopup(WeatherForecast weatherForecast)
    {
        WDate = weatherForecast.Date.ToString();
        WSummary = weatherForecast.Summary;

        isOpened = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastClient WfClient { get; set; }
    }
}
#pragma warning restore 1591