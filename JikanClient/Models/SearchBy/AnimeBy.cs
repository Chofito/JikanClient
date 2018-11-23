using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.SearchBy
{
    public class AnimeBy
    {
        [JsonProperty(PropertyName = "mal_url")]
        public MalBasicItem MalUrl { get; set; }

        [JsonProperty(PropertyName = "item_count")]
        public int? ItemCount { get; set; }

        [JsonProperty(PropertyName = "anime")]
        public ICollection<AnimeBasic> Animes { get; set; }
    }
}