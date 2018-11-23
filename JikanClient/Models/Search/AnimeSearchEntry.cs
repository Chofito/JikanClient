using System;
using Newtonsoft.Json;

namespace JikanClient.Models.Search
{
    public class AnimeSearchEntry
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int MalId { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "airing")]
        public bool? Airing { get; set; }

        [JsonProperty(PropertyName = "synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "episodes")]
        public int? Episodes { get; set; }

        [JsonProperty(PropertyName = "score")]
        public float? Score { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        [JsonProperty(PropertyName = "members")]
        public int? Members { get; set; }

        [JsonProperty(PropertyName = "rated")]
        public string Rated { get; set; }
    }
}
