using SmartSetList.Spotify.Entities;
using Microsoft.AspNetCore.Mvc;
using SmartSetList.Spotify.Services.Auth.Interfaces;
using Microsoft.AspNetCore.Authorization;
using SmartSetList.Shared.Entities;

namespace SmartSetList.Spotify.Controllers.Auth
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly ISpotifyAuthService _spotifyAuthService;
        private ILogger<AuthController> _logger;
        public AuthController(ISpotifyAuthService spotifyAuthService)
        {
            _spotifyAuthService = spotifyAuthService;
            //_logger = logger;
            _spotifyAuthService = spotifyAuthService;
        }

        [HttpGet]
        [AllowAnonymous]
        public string RequestUserAuthorization()
        {
            var url = _spotifyAuthService.RequestUserAuthorization();

            return url;
        }
        [HttpPost]
        public AccessToken RequestToken(string code, bool publicAccess)
        {
            var ret = _spotifyAuthService.RequestToken(code, false);


            return ret;
        }
    }
}
