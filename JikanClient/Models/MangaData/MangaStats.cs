using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.MangaData
{
    public class MangaStats
    {
        [JsonProperty(PropertyName = "reading")]
        public int? Reading { get; set; }

        [JsonProperty(PropertyName = "completed")]
        public int? Completed { get; set; }

        [JsonProperty(PropertyName = "on_hold")]
        public int? OnHold { get; set; }

        [JsonProperty(PropertyName = "dropped")]
        public int? Dropped { get; set; }

        [JsonProperty(PropertyName = "plan_to_read")]
        public int? PlanToRead { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }

        [JsonProperty(PropertyName = "scores")]
        public Scores Scores { get; set; }
    }
}