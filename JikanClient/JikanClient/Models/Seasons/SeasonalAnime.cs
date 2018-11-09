using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Seasons
{
    public class SeasonalAnime : AnimeBasic
    {
        [JsonProperty(PropertyName = "continuing")]
        public bool? Continuing { get; set; }
    }
}