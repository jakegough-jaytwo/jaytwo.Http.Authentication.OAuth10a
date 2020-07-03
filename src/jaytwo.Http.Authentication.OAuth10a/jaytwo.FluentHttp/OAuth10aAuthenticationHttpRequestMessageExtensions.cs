using System;
using System.Net.Http;
using jaytwo.FluentHttp.Authentication.OAuth10a;

namespace jaytwo.FluentHttp
{
    public static class OAuth10aAuthenticationHttpRequestMessageExtensions
    {
        public static HttpRequestMessage WithOAuth10aAuthentication(this HttpRequestMessage httpRequestMessage, string consumerKey, string consumerSecret)
        {
            return httpRequestMessage.WithAuthentication(new OAuth10aAuthenticationProvider(consumerKey, consumerSecret));
        }

        public static HttpRequestMessage WithOAuth10aAuthentication(this HttpRequestMessage httpRequestMessage, string consumerKey, string consumerSecret, string token, string tokenSecret)
        {
            return httpRequestMessage.WithAuthentication(new OAuth10aAuthenticationProvider(consumerKey, consumerSecret, token, tokenSecret));
        }
    }
}
