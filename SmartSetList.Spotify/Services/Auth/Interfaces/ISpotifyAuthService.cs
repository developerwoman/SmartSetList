using SmartSetList.Shared.Entities;

namespace SmartSetList.Spotify.Services.Auth.Interfaces
{
    public interface ISpotifyAuthService
    {
        public string RequestUserAuthorization();
        public AccessToken RequestToken(string code, bool publicAccess);
    }
}
