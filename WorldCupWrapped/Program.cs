using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WorldCupWrapped.Data;
using WorldCupWrapped.Helpers.Extensions;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(
    builder.Services,
    builder.Configuration
);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddRepositories();
builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

//app.MapGet("/players", async (AppDbContext db) => await db.Players.ToListAsync()).Produces<List<Player>>(StatusCode.Status200OK);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();

void ConfigureServices(IServiceCollection services, ConfigurationManager configManager)
{
    services.AddDbContext<ProjectContext>(
        opts =>
        {
            opts.UseNpgsql(configManager.GetConnectionString("AppDb"));
        }, ServiceLifetime.Transient);
    /*services.AddDbContext<ProjectContext>(options =>
        options.UseNpgsql(configManager.GetConnectionString("AppDb")));*/
}


