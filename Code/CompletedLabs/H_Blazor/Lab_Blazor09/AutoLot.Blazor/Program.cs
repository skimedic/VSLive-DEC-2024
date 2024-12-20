// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - Program.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AutoLot.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.Configure<ApiServiceSettings>(
    builder.Configuration.GetSection(nameof(ApiServiceSettings)));
builder.Services.AddHttpClient<ICarApiServiceWrapper, CarApiServiceWrapper>();
builder.Services.AddHttpClient<IMakeApiServiceWrapper, MakeApiServiceWrapper>();

builder.Services.AddTransient<OutputLog>();

//builder.Services.AddScoped<ICarDataService, CarDataService>();
//builder.Services.AddScoped<IMakeDataService, MakeDataService>();
if (builder.Configuration.GetValue<bool>("UseApi"))
{
    builder.Services.AddScoped<ICarDataService, CarApiDataService>();
    builder.Services.AddScoped<IMakeDataService, MakeApiDataService>();
}
else
{
    builder.Services.AddScoped<ICarDataService, CarDataService>();
    builder.Services.AddScoped<IMakeDataService, MakeDataService>();
}

builder.Services.Configure<DealerInfo>(builder.Configuration.GetSection(nameof(DealerInfo)));

builder.Services.AddKeyedScoped<IBrowserStorageService, LocalStorageService>(nameof(LocalStorageService));
builder.Services.AddKeyedScoped<IBrowserStorageService, SessionStorageService>(nameof(SessionStorageService));

await builder.Build().RunAsync();
