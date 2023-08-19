using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Users.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<CityService>();
builder.Services.AddSingleton<TGRegistrationService>();

builder.Services.AddHttpClient<ICityService, CityService>(e =>
{
    e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<ITGRegistrationService, TGRegistrationService>(e =>
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
