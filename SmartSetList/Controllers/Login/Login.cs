using Microsoft.AspNetCore.Mvc;
using SmartSetList.Shared.Entities;
using SmartSetList.Spotify.Controllers;
using SmartSetList.Spotify.Controllers.Auth;
using SmartSetList.Spotify.Entities;
using SmartSetList.Spotify.Services.Auth.Interfaces;


namespace SmartSetList.Web.Controllers.Login
{
    public class Login : Controller
    {
        private ISpotifyAuthService _spotifyAuthService;
        private AuthController authController;
        //private readonly ILogger<Login> _loggerLogin;
        //private readonly ILogger<AuthController> _loggerAuthController;
        public Login(ISpotifyAuthService spotifyAuthService)
        {
            _spotifyAuthService = spotifyAuthService;
            authController = new AuthController(_spotifyAuthService);

        }
        public IActionResult Index()
        {
            var url = authController.RequestUserAuthorization();
            return Redirect(url);
        }



        //public IActionResult GetToken(string? code)
        //{
        //    if (string.IsNullOrEmpty(code))
        //    {
        //        return BadRequest("Código de autorização inválido");
        //    }
        //    AccessToken ret = authController.RequestToken(code, true);

        //    return View();
        //}
    }
}
