using API.Entities;
using API.Services;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly ISpotifyAuthService _spotifyAuthService;
        private ILogger<AuthController> _logger;
        public AuthController(ILogger<AuthController> logger, ISpotifyAuthService spotifyAuthService)
        {
            _spotifyAuthService = spotifyAuthService;
            _logger = logger;
            _spotifyAuthService = spotifyAuthService;
        }

        [HttpGet]
        public string RequestUserAuthorization()
        {
            var ret = _spotifyAuthService.RequestUserAuthorization();
            return "oi";
        }
        [HttpPost]
        public AcessToken RequestToken()
        {
            var ret = _spotifyAuthService.RequestToken();

            AcessToken token = new AcessToken();
            return token;
        }
    }
}
