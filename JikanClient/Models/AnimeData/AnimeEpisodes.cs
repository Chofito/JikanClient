using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.AnimeData
{
    public class AnimeEpisodes
    {
        [JsonProperty(PropertyName = "episodes_last_page")]
        public int? EpisodesLastPage { get; set; }

        [JsonProperty(PropertyName = "episodes")]
        public ICollection<Episode> Episodes { get; set; }
    }
}