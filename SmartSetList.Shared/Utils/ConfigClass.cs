using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static SmartSetList.Shared.Utils.Constants;

namespace SmartSetList.Shared.Utils
{
    public static class ConfigClass
    {
        private static IConfiguration? _config;

        public static void Instantiate(IConfiguration config)
        {
            _config = config;            
        }        

        public static string? GetAuthURI()
        {
            if (_config != null)
            {
                return _config.GetSection("Spotify:AuthURI").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.AuthURI);
            }
        }

        public static string? GetRedirectURI()
        {
            if (_config != null)
            {
                return _config.GetSection("Spotify:RedirectURI").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SmartSetListApp.RedirectURI);
            }
        }
        public static string? GetTokenURI()
        {
            if (_config != null)
            {
                return _config.GetSection("Spotify:TokenURI").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.TokenURI);
            }
        }
        public static string? GetGrantTypeCredentials()
        {
            if (_config != null)
            {
                return _config.GetSection("Spotify:GrantTypeCredentials").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.GrantTypeCredentials);
            }
        }

        public static string? GetGrantTypeAuthCode()
        {
            if (_config != null)
            {
                return _config.GetSection("Spotify:GrantTypeAuthCode").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.GrantTypeAuthCode);
            }
        }
        public static string? GetClientSecret()
        {
            if (_config != null)
            {
                return _config.GetSection("Spotify:ClientSecret").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.ClientSecret);
            }
        }
        public static string? GetClientId()
        {

            if (_config != null)
            {
                return _config.GetSection("Spotify:ClientID").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.ClientID);
            }

        }
        public static string? GetScopes()
        {
            if (_config != null)
            {
                return _config.GetSection("Spotify:Scope").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.Scope);
            }
        }

        public static string? GetShowDialog()
        {
            if (_config != null)
            {
                return _config.GetSection("ShowDialogAfter").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SmartSetListApp.ShowDialogAfter);
            }
        }
    }
}
