namespace API.Services.Interfaces
{
    public interface ISpotifyAuthService
    {
        public bool RequestUserAuthorization();
        public string RequestToken();
    }
}
