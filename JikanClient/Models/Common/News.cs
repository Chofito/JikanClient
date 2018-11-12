using System;
using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class News
    {
        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "title")] public string Title { get; set; }

        [JsonProperty(PropertyName = "date")] public DateTime? Date { get; set; }

        [JsonProperty(PropertyName = "author_name")]
        public string AuthorName { get; set; }

        [JsonProperty(PropertyName = "author_url")]
        public string AuthorUrl { get; set; }

        [JsonProperty(PropertyName = "forum_url")]
        public string ForumUrl { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public int? Comments { get; set; }

        [JsonProperty(PropertyName = "intro")] public string Intro { get; set; }
    }
}