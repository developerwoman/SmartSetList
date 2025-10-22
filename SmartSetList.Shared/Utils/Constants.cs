using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSetList.Shared.Utils
{
    public class Constants
    {
        public class ContentType
        {
            public const string application_json = "application/json";
            public const string application_x_www_form_urlencoded = "application/x-www-form-urlencoded";
            public const string text_html = "text/html";
            public const string text_plain = "text/plain";
        }

        public class SmartSetListApp
        {
            public const string RedirectURI = "RedirectURI";
            public const string ShowDialogAfter = "ShowDialogAfter";
        }

        public class SpotifyConfig
        {
            public const string AuthURI = "AuthURI";
            public const string ClientID = "ClientID";
            public const string ClientSecret = "ClientSecret";
            public const string Scope = "Scope";
            public const string TokenURI = "TokenURI";
            public const string GrantTypeCredentials = "GrantTypeCredentials";
            public const string GrantTypeAuthCode = "GrantTypeAuthCode";
        }
    }
}
