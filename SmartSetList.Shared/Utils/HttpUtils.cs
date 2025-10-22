using SmartSetList.Shared.Entities;

namespace SmartSetList.Shared.Utils
{
    public class HttpUtils
    {
        public string WebGet(string Uri, string responseType, string clientId, string Scope, string redirectURI, string State)
        {
            try
            {
                var url = Uri +
                        "response_type=" + responseType + "&client_id=" + clientId + "&scope=" + Scope + "&redirect_uri=" + redirectURI
                        + "&state=" + State + "&show_dialog=true";

                return url;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AccessToken RequestToken(string Uri, string grantType, string clientId, string clientSecret, string code)
        {
            try
            {
                var param = "grant_type=" + grantType + "&client_id=" + clientId + "&client_secret=" + clientSecret;


                var url = Uri.Concat(param);
            }
            catch (Exception)
            {

                throw;
            }
            AccessToken token = new AccessToken();
            return token;
        }

    }
}
