using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AuthController : Controller
    {
        private ISpotifyAuthService _spotifyService;
        private ILogger<AuthenticationController> _logger;
        public AuthenticationController(ILogger<AuthenticationController> logger, ISpotifyAuthService spotifyService)
        {
            _spotifyService = spotifyService;
            _logger = logger;
        }

        [HttpGet]
        public string RequestUserAuthorization()
        {
            var ret = _spotifyService.RequestUserAuthorization();
            return "oi";
        }
    }
}
