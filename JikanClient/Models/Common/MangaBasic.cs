using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class MangaBasic
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty(PropertyName = "type")] public string Type { get; set; }

        [JsonProperty(PropertyName = "publishing_start")]
        public DateTime? PublishingStart { get; set; }

        [JsonProperty(PropertyName = "volumes")]
        public int? Volumes { get; set; }

        [JsonProperty(PropertyName = "members")]
        public int? Members { get; set; }

        [JsonProperty(PropertyName = "genres")]
        public ICollection<Genre> Genres { get; set; }

        [JsonProperty(PropertyName = "authors")]
        public ICollection<MalBasicItem> Authors { get; set; }

        [JsonProperty(PropertyName = "score")] public float? Score { get; set; }

        [JsonProperty(PropertyName = "serialization")]
        public ICollection<string> Serialization { get; set; }
    }
}