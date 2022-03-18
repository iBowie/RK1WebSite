using Microsoft.EntityFrameworkCore;
using RK1WebSite.Data;
using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Models;
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

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => ShopCart.GetCart(sp));

builder.Services.AddMemoryCache();
builder.Services.AddSession();

var app = builder.Build();

app.UseSession();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvc(routes =>
{
    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
    routes.MapRoute("categoryFilter", "Cars/{action}/{category?}", new {Controller = "Cars", action = "List", });
});

using (var scope = app.Services.CreateScope())
{
    AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    DbObjects.Initial(context);
}

app.Run();
