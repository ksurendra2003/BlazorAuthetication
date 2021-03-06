#pragma checksum "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca4a4814397653111cf53ca66eba4633088cfa8"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 12 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 28 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
                                     (() => OpenPopup(forecast))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, 
#nullable restore
#line 32 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
                                                                    forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 34 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 35 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 36 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<BlazorApp5.Shared.ModelPopUp>(21);
            __builder.AddAttribute(22, "Title", "This is my Popup");
            __builder.AddAttribute(23, "IsOpened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
                                                   isOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ModelBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row");
                __builder2.AddMarkupContent(27, "<div>Date</div>\r\n                ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "type", "text");
                __builder2.AddAttribute(30, "id", "enpname");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
                                                WDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => WDate = __value, WDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "row");
                __builder2.AddMarkupContent(36, "<div>Summary</div>\r\n                ");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "type", "text");
                __builder2.AddAttribute(39, "value", 
#nullable restore
#line 50 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
                                           WSummary

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(40, "id", "enpdept");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 54 "C:\Users\surendra_babu1\source\repos\BlazorApp5\BlazorApp5\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
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
