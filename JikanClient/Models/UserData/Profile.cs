using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.UserData
{
    public class Profile
    {
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "last_online")]
        public DateTime? LastOnline { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "birthday")]
        public DateTime? Birthday { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "joined")]
        public DateTime? Joined { get; set; }

        [JsonProperty(PropertyName = "anime_stats")]
        public UserAnimeStats AnimeStats { get; set; }

        [JsonProperty(PropertyName = "manga_stats")]
        public UserMangaStats MangaStats { get; set; }

        [JsonProperty(PropertyName = "favorites")]
        public ICollection<UserFavorites> Favorites { get; set; }

        [JsonProperty(PropertyName = "about")]
        public string About { get; set; }
    }
}