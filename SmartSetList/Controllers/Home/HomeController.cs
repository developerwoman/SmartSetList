using Microsoft.AspNetCore.Mvc;
using SmartSetList.Models;
using SmartSetList.Spotify.Services.Auth.Interfaces;
using System.Diagnostics;

namespace SmartSetList.Web.Controllers.Home
{
    public class HomeController : Controller
    {
        private ISpotifyAuthService _spotifyAuthService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ISpotifyAuthService spotifyAuthService)
        {
            _logger = logger;
            _spotifyAuthService = spotifyAuthService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
     
        public IActionResult Logout()
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
