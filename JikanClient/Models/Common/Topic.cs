using System;
using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class Topic
    {
        [JsonProperty(PropertyName = "topic_id")]
        public int? TopicId { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "date_posted")]
        public DateTime? DatePosted { get; set; }

        [JsonProperty(PropertyName = "author_name")]
        public string AuthorName { get; set; }

        [JsonProperty(PropertyName = "author_url")]
        public string AuthorUrl { get; set; }

        [JsonProperty(PropertyName = "replies")]
        public int? Replies { get; set; }

        [JsonProperty(PropertyName = "last_post")]
        public PostEntry LastPost { get; set; }
    }
}