using API.Services.Interfaces;
using RandomString4Net;
using Utils;

namespace API.Services
{
    public class SpotifyAuthService : ISpotifyAuthService
    {
        private HttpUtils _utils = new HttpUtils();
        private string _uriRequestAuthorization;
        private string _uriGetToken;
        private string _redirectURI;
        private string _clientId;
        private string _clientSecret;
        private string _responseType = "code";
        private string _state = RandomString.GetString(Types.ALPHABET_LOWERCASE, 15);
        private string _scope;
        private string _grantType;
        private readonly IConfiguration _configuration;

        public SpotifyAuthService(IConfiguration configuration)
        {
            _configuration = configuration;
            ConfigClass.Instantiate(_configuration);
            _uriRequestAuthorization = ConfigClass.GetAuthURI();
            _redirectURI = ConfigClass.GetRedirectURI();
            _clientId = ConfigClass.GetClientId();
            _scope = ConfigClass.GetScopes();
            _clientSecret = ConfigClass.GetClientSecret();
            _uriGetToken = ConfigClass.GetTokenURI();
            _grantType = ConfigClass.GetGrantType();
            _configuration = configuration;
        }
        public bool RequestUserAuthorization()
        {
            return _utils.WebGet(_uriRequestAuthorization, _responseType, _clientId, _scope, _redirectURI, _state);
        }

        public string RequestToken()
        {
            return _utils.WebPost(_uriGetToken, _grantType, _clientId, _clientSecret);
        }
    }
}
