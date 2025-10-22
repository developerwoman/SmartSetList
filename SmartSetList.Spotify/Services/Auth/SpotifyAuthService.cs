using RandomString4Net;
using SmartSetList.Shared.Entities;
using SmartSetList.Shared.Utils;
using SmartSetList.Spotify.Entities;
using SmartSetList.Spotify.Services.Auth.Interfaces;

namespace SmartSetList.Spotify.Services.Auth
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
        private string _grantTypeCredentials;
        private string _grantTypeAuthCode;
        private string _showDialogAfter;
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
            _grantTypeCredentials = ConfigClass.GetGrantTypeCredentials();
            _grantTypeAuthCode = ConfigClass.GetGrantTypeAuthCode();
            //_showDialogAfter
            _configuration = configuration;
        }
        public string RequestUserAuthorization()
        {
            return _utils.WebGet(_uriRequestAuthorization, _responseType, _clientId, _scope, _redirectURI, _state);
        }

        public AccessToken RequestToken(string code, bool publicAccess)
        {
            if (publicAccess)
            {
                return _utils.RequestToken(_uriGetToken, _grantTypeCredentials, _clientId, _clientSecret, code);
            }
            else 
            {
                return _utils.RequestToken(_uriGetToken, _grantTypeAuthCode, _clientId, _clientSecret, code);
            }            
        }
    }
}
