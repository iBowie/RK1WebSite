using Microsoft.EntityFrameworkCore;
using RK1WebSite.Data;
using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

IWebHostEnvironment hostEnv = builder.Environment;
IConfigurationRoot confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(confString.GetConnectionString("DefaultConnection"));
});
builder.Services.AddTransient<IAllCars, CarRepository>();
builder.Services.AddTransient<ICarsCategory, CategoryRepository>();
builder.Services.AddMvc((options) =>
{
    options.EnableEndpointRouting = false;
});

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();

using (var scope = app.Services.CreateScope())
{
    AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    DbObjects.Initial(context);
}

app.Run();
