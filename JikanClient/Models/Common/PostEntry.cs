using System;
using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class PostEntry
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "author_name")]
        public string AuthorName { get; set; }

        [JsonProperty(PropertyName = "author_url")]
        public string AuthorUrl { get; set; }

        [JsonProperty(PropertyName = "date_posted")]
        public DateTime? DatePosted { get; set; }
    }
}