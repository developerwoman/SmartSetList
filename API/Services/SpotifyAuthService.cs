using API.Services.Interfaces;
using RandomString4Net;
using Utils;
using Utils.Config;

namespace API.Services
{
    public class SpotifyAuthService : ISpotifyService
    {
        private HttpUtils _utils;
        private string _uriRequestAuthorization;
        private string _uriGetToken;
        private string _redirectURI;
        private string _clientId;
        private string _clientSecret;
        private string _responseType = "code";
        private string _state = RandomString.GetString(Types.ALPHABET_LOWERCASE, 15);
        private string _scope;
        private string _grantType;
        private ConfigClass _confClass;
        public SpotifyAuthService(HttpUtils utils, ConfigClass confClass)
        {
            _utils = utils;
            _confClass = confClass;
            _uriRequestAuthorization = ConfigClass.GetAuthURI();
            _redirectURI = ConfigClass.GetRedirectURI();
            _clientId = ConfigClass.GetClientId();
            _scope = ConfigClass.GetScopes();
            _clientSecret = ConfigClass.GetClientSecret();
            _uriGetToken = ConfigClass.GetTokenURI();
            _grantType = ConfigClass.GetGrantType();
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
