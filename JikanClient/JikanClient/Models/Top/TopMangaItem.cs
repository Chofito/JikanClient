using Newtonsoft.Json;

namespace JikanClient.Models.Top
{
    public class TopMangaItem
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "rank")] public int? Rank { get; set; }

        [JsonProperty(PropertyName = "title")] public string Title { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "type")] public string Type { get; set; }

        [JsonProperty(PropertyName = "volumes")]
        public int? Volumes { get; set; }

        [JsonProperty("start_date")] public string StartDate { get; set; }

        [JsonProperty("end_date")] public string EndDate { get; set; }

        [JsonProperty("members")] public int? Members { get; set; }

        [JsonProperty("score")] public float? Score { get; set; }

        [JsonProperty("image_url")] public string ImageUrl { get; set; }
    }
}