using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Genres
{
    public class MangaByGenre
    {
        [JsonProperty(PropertyName = "mal_url")]
        public MalBasicItem Description { get; set; }

        [JsonProperty(PropertyName = "item_count")]
        public int? ItemCount { get; set; }

        [JsonProperty(PropertyName = "anime")]
        public ICollection<MangaBasic> Animes { get; set; }
    }
}