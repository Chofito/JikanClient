using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Seasons
{
    public class Season
    {
        [JsonProperty(PropertyName = "season_name")]
        public string SeasonName { get; set; }

        [JsonProperty(PropertyName = "season_year")]
        public int? SeasonYear { get; set; }

        [JsonProperty(PropertyName = "anime")] public ICollection<SeasonalAnime> Animes { get; set; }
    }
}