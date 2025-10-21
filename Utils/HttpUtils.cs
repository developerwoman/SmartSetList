namespace Utils
{
    public class HttpUtils
    {
        public bool WebGet(string Uri, string responseType, string clientId, string Scope, string redirectURI, string State)
        {
            try
            {
                string responseBody = "";
                var url = Uri +
                        "response_type=" + responseType + "&client_id=" + clientId + "&scope=" + Scope + "&redirect_uri=" + redirectURI
                        + "&state=" + State;
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), Uri))
                    {
                        var response = httpClient.SendAsync(request).Result;
                        {
                            responseBody = response.Content.ReadAsStringAsync().Result;
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string WebPost(string Uri, string grantType, string clientId, string clientSecret)
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
            return "";
        }

    }
}
