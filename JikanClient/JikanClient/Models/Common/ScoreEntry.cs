using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class ScoreEntry
    {
        [JsonProperty(PropertyName = "votes")] public int? Votes { get; set; }

        [JsonProperty(PropertyName = "percentage")]
        public float? Percentage { get; set; }
    }
}