using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Constants;

namespace Utils.Config
{
    public class ConfigClass
    {
        private static IConfiguration? _config;
        public ConfigClass(IConfiguration configuration)
        {
            _config = configuration;
        }

        public static string? GetAuthURI()
        {
            if (_config != null)
            {
                return _config.GetSection("AuthURI").ToString();
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
                return _config.GetSection("RedirectURI").ToString();
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
                return _config.GetSection("TokenURI").ToString();
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
                return _config.GetSection("GrantType").ToString();
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
                return _config.GetSection("ClientSecret").ToString();
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
                return _config.GetSection("ClientID").ToString();
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
                return _config.GetSection("Scope").ToString();
            }
            else
            {
                return Environment.GetEnvironmentVariable(SpotifyConfig.Scope);
            }
        }
    }
}
