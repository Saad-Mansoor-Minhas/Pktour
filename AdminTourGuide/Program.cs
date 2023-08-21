using AdminTourGuide.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<ICityService, CityService>();
builder.Services.AddSingleton<IAreaService, AreaService>();
builder.Services.AddSingleton<ITGRegistrationService, TGRegistrationService>();
builder.Services.AddSingleton<ICompanyRegistrationService, CompanyRegistrationService>();
builder.Services.AddSingleton<IServiceCategoryService, ServiceCategoryService>();
builder.Services.AddSingleton<IServiceSubCategoryService, ServiceSubCategoryService>();
builder.Services.AddSingleton<IServiceDetailsService, ServiceDetailsService>();
builder.Services.AddSingleton<ICompanyServicesService, CompanyServicesService>();
builder.Services.AddSingleton<ITourPackageService, TourPackageService>();

builder.Services.AddHttpClient<ICityService,CityService>(e =>
{
    e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<IAreaService,AreaService>(e =>
{
	e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<ITGRegistrationService, TGRegistrationService>(e =>
{
    e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<ICompanyRegistrationService, CompanyRegistrationService>(e =>
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

builder.Services.AddHttpClient<ICompanyServicesService, CompanyServicesService>(e =>
{
	e.BaseAddress = new Uri("http://localhost:5179/");
});

builder.Services.AddHttpClient<ITourPackageService, TourPackageService>(e =>
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
