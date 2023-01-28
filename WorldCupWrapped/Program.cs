using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Linq;
using System.Net;
using WorldCupWrapped.Data;
using WorldCupWrapped.Helpers;
using WorldCupWrapped.Helpers.Extensions;
using WorldCupWrapped.Helpers.Middleware;
using WorldCupWrapped.Helpers.Seeders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<ProjectContext>(opts => { opts.UseNpgsql(builder.Configuration.GetConnectionString("AppDb")); }, ServiceLifetime.Transient);
builder.Services.AddControllersWithViews();
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddSeeders();
builder.Services.AddUtils();
builder.Services.AddEndpointsApiExplorer();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

SeedDataAsync(app);

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseMiddleware<JwtMiddleware>();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;
app.UseCors("corsapp");
app.Run();


string WCLogin()
{
    var url = "http://api.cup2022.ir/api/v1/user/login";
    var httpRequest = (HttpWebRequest)WebRequest.Create(url);
    httpRequest.Method = "POST";
    httpRequest.Accept = "application/json";
    httpRequest.ContentType = "application/json";
    var data = @"{
              ""email"": ""radu2002ro@gmail.com"",
              ""password"": ""worldCupApi2022""
            }";
    using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
    {
        streamWriter.Write(data);
    }

    var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
    var streamReader = new StreamReader(httpResponse.GetResponseStream());
    var response = streamReader.ReadToEnd();
    JObject joResponse = JObject.Parse(response);
    var token = joResponse["data"]["token"];

    return (string)token;
}
async Task SeedDataAsync(IHost app)
{
    var scope = app.Services.GetService<IServiceScopeFactory>().CreateScope();

    using var context = new ProjectContext(
            scope.ServiceProvider.GetRequiredService
            <DbContextOptions<ProjectContext>>());
    var token = WCLogin();

    var serviceManager = new ManagerSeeder(context);
    serviceManager.SeedInitialManagers();

    var serviceTrophy = new TrophySeeder(context);
    serviceTrophy.SeedInitialTrophies();

    var serviceTeam = new TeamSeeder(context);
    await serviceTeam.SeedInitialTeamsAsync(token);

    var serviceCity = new CitySeeder(context);
    serviceCity.SeedInitialCities();

    var serviceStadium = new StadiumSeeder(context);
    serviceStadium.SeedInitialStadiums();

    var serviceTeamTrophy = new TeamTrophySeeder(context);
    serviceTeamTrophy.SeedInitialTeamsTrophies();

    var serviceReferee = new RefereeSeeder(context);
    serviceReferee.SeedInitialReferees();

    var serviceMatches = new MatchSeeder(context);
    await serviceMatches.SeedInitialMatchesAsync(token, builder.Configuration.GetConnectionString("AppDb"));

    var servicePlayer = new PlayerSeeder(context);
    await servicePlayer.SeedInitialPlayersAsync(token, builder.Configuration.GetConnectionString("AppDb"));
}
