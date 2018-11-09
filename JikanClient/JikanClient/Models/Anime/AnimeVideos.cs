using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class AnimeVideos
    {
        [JsonProperty(PropertyName = "promo")] public ICollection<PromoVideo> PromoVideos { get; set; }

        [JsonProperty(PropertyName = "episodes")]
        public ICollection<EpisodeVideo> EpisodeVideos { get; set; }
    }
}