#pragma checksum "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f974c3e31c8b3008dce94c11d3c7c90490ebed02"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Frente_de_Trabalho_Sem_a_Vale.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\_Imports.razor"
using Frente_de_Trabalho_Sem_a_Vale;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\_Imports.razor"
using Frente_de_Trabalho_Sem_a_Vale.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\Pages\FetchData.razor"
using Frente_de_Trabalho_Sem_a_Vale.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\Pages\FetchData.razor"
using ModelShared;

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
#line 41 "C:\Users\jbazzoli\source\repos\Frente de Trabalho Sem a Vale\Frente de Trabalho Sem a Vale\Pages\FetchData.razor"
       
 
    private List<WeatherForecast >forecasts = new List<WeatherForecast>();

    protected override async Task OnInitializedAsync()
    {
        var forecastsTeste =  await ForecastService.GetWeatherForecastAsync();
       
        foreach(var iten in forecastsTeste)
        {
            forecasts.Add(new WeatherForecast() { Date = iten.Date, Summary = iten.Summary,TemperatureC = iten.TemperatureC});
       
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
