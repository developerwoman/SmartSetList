namespace API.Services.Interfaces
{
    public interface ISpotifyService
    {
        public bool RequestUserAuthorization();
        public string RequestToken();
    }
}
