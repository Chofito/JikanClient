using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class AnimeStats
    {
        [JsonProperty(PropertyName = "Watching")]
        public int? Watching { get; set; }

        [JsonProperty(PropertyName = "completed")]
        public int? Completed { get; set; }

        [JsonProperty(PropertyName = "on_hold")]
        public int? OnHold { get; set; }

        [JsonProperty(PropertyName = "dropped")]
        public int? Dropped { get; set; }

        [JsonProperty(PropertyName = "plan_to_watch")]
        public int? PlanToWatch { get; set; }

        [JsonProperty(PropertyName = "total")] public int? Total { get; set; }

        [JsonProperty(PropertyName = "scores")]
        public Scores Scores { get; set; }
    }
}