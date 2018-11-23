using Newtonsoft.Json;

namespace JikanClient.Models.UserData
{
    public class UserMangaStats
    {
        [JsonProperty(PropertyName = "days_read")]
        public float? DaysRead { get; set; }

        [JsonProperty(PropertyName = "mean_score")]
        public int? MeanScore { get; set; }

        [JsonProperty("PropertyName = reading")]
        public int? Reading { get; set; }

        [JsonProperty(PropertyName = "completed")]
        public int? Completed { get; set; }

        [JsonProperty(PropertyName = "on_hold")]
        public int? OnHold { get; set; }

        [JsonProperty(PropertyName = "dropped")]
        public int? Dropped { get; set; }

        [JsonProperty(PropertyName = "plan_to_read")]
        public int? PlanToRead { get; set; }

        [JsonProperty(PropertyName = "total_entries")]
        public int? TotalEntries { get; set; }

        [JsonProperty(PropertyName = "reread")]
        public int? Reread { get; set; }

        [JsonProperty(PropertyName = "chapters_read")]
        public int? ChaptersRead { get; set; }

        [JsonProperty(PropertyName = "volumes_read")]
        public int? VolumesRead { get; set; }
    }
}