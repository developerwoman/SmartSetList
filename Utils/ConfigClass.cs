using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Utils.Constants;

namespace Utils
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
                return _config.GetSection("RedirectURI").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SmartSetURI.RedirectURI);
            }
        }
        public static string? GetTokenURI()
        {
            if (_config != null)
            {
                return _config.GetSection("TokenURI").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.TokenURI);
            }
        }
        public static string? GetGrantType()
        {
            if (_config != null)
            {
                return _config.GetSection("GrantType").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.GrantType);
            }
        }
        public static string? GetClientSecret()
        {
            if (_config != null)
            {
                return _config.GetSection("ClientSecret").Value;
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
                return _config.GetSection("Scope").Value;
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.Scope);
            }
        }
    }
}
