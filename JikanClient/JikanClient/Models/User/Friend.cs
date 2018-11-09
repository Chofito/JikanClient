using System;
using Newtonsoft.Json;

namespace JikanClient.Models.User
{
    public class Friend
    {
        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "last_online")]
        public DateTime? LastOnline { get; set; }

        [JsonProperty(PropertyName = "friends_since")]
        public DateTime? FriendsSince { get; set; }
    }
}