using Admin.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<CityService>();
builder.Services.AddSingleton<ViewpointService>();
builder.Services.AddSingleton<ServiceCategoryService>();
builder.Services.AddSingleton<ServiceSubCategoryService>();
builder.Services.AddSingleton<ServiceDetailsService>();
builder.Services.AddSingleton<TourGuideRegistrationService>();

builder.Services.AddHttpClient<ICityService, CityService>(e =>
{
	e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<IViewpointService, ViewpointService>(e =>
{
	e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<IServiceCategoryService, ServiceCategoryService>(e =>
{
	e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<IServiceSubCategoryService, ServiceSubCategoryService>(e =>
{
	e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<IServiceDetailsService, ServiceDetailsService>(e =>
{
    e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<ITourGuideRegistrationService, TourGuideRegistrationService>(e =>
{
	e.BaseAddress = new Uri("http://localhost:5179/");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();