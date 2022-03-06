using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Mocks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IAllCars, MockAllCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();
builder.Services.AddMvc((options) =>
{
    options.EnableEndpointRouting = false;
});

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();

app.Run();
