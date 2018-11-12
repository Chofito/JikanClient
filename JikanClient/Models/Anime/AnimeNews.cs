using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class AnimeNews
    {
        [JsonProperty(PropertyName = "articles")]
        public ICollection<News> Articles { get; set; }
    }
}