using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace JikanClient.Connection
{
    public static class HttpProvider
    {
        private const string JikanApi = "https://api.jikan.moe";

        public static HttpClient JikanHttpClient { get; set; }

        static HttpProvider()
        {
            JikanHttpClient = new HttpClient()
            {
                BaseAddress = new Uri(JikanApi)
            };
            JikanHttpClient.DefaultRequestHeaders.Accept.Clear();
            JikanHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static HttpClient GetJikanHttpClient()
        {
            if (JikanHttpClient == null)
            {
                JikanHttpClient = new HttpClient()
                {
                    BaseAddress = new Uri(JikanApi)
                };
                JikanHttpClient.DefaultRequestHeaders.Accept.Clear();
                JikanHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            return JikanHttpClient;
        }
    }
}