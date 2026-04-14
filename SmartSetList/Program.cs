using SmartSetList.Spotify.Services.Auth;
using SmartSetList.Spotify.Services.Auth.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ISpotifyAuthService, SpotifyAuthService>();
var apiAppSettings = @"C:/Users/a.regato.azevedo/source/repos/SmartSetList/SmartSetList.Spotify/appsettings.json";


builder.Configuration.AddJsonFile(apiAppSettings, optional: false, reloadOnChange: true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
