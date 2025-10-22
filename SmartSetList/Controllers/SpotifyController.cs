using Microsoft.AspNetCore.Mvc;
using API.Services.Interfaces;
using API.Services;

namespace SmartSetList.Controllers
{
    public class SpotifyController : Controller
    {
        ISpotifyAuthService _spotifyService;

        private readonly string clientId = "78b1bfd41bce4f2ba43bb00dd43f2b68";
        private readonly string ClientSecret = "ab78a5bc54284db984cf381880c1c063";
        private readonly string AuthURI = "https://accounts.spotify.com/authorize?";
        private readonly string TokenURI = "https://accounts.spotify.com/api/token";
        private readonly string RedirectURI = "https://localhost:44347/Spotify/Callback";
        private readonly string Scope = "playlist-read-private user-library-read";
        private readonly string GrantType = "client_credentials";
        private readonly string ResponseType = "code";

        public SpotifyController(ISpotifyAuthService spotifyService)
        {
            _spotifyService = spotifyService;
        }
        public IActionResult Login()
        {
            var url = $"https://accounts.spotify.com/authorize?response_type=code&client_id={clientId}&scope={Uri.EscapeDataString(Scope)}&redirect_uri={Uri.EscapeDataString(RedirectURI)}";
            return Redirect(url);
        }

        public async Task<IActionResult> Callback(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return  BadRequest("Código de autorização inválido");
            }
            //_spotifyService.RequestUserAuthorization();
            return View();
        }
    }
}
