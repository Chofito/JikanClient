using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class AnimeBasic
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "airing_start")]
        public DateTime? AiringStart { get; set; }

        [JsonProperty(PropertyName = "episodes")]
        public int? Episodes { get; set; }

        [JsonProperty(PropertyName = "members")]
        public int? Members { get; set; }

        [JsonProperty(PropertyName = "genres")]
        public ICollection<Genre> Genres { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "producers")]
        public ICollection<Producer> Producers { get; set; }

        [JsonProperty(PropertyName = "score")]
        public float? Score { get; set; }

        [JsonProperty(PropertyName = "licensors")]
        public ICollection<string> Licensors { get; set; }

        [JsonProperty(PropertyName = "r18")]
        public bool? R18 { get; set; }

        [JsonProperty(PropertyName = "kids")]
        public bool? Kids { get; set; }
    }
}