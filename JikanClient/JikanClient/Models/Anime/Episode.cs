using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class Episode
    {
        [JsonProperty(PropertyName = "episode_id")]
        public int? EpisodeId { get; set; }

        [JsonProperty(PropertyName = "title")] public string Title { get; set; }

        [JsonProperty(PropertyName = "title_japanese")]
        public string TitleJapanese { get; set; }

        [JsonProperty(PropertyName = "title_romanji")]
        public string TitleRomanji { get; set; }

        [JsonProperty(PropertyName = "aired")] public TimePeriod Aired { get; set; }

        [JsonProperty(PropertyName = "filler")]
        public bool? Filler { get; set; }

        [JsonProperty(PropertyName = "recap")] public bool? Recap { get; set; }

        [JsonProperty(PropertyName = "video_url")]
        public string VideoUrl { get; set; }

        [JsonProperty(PropertyName = "forum_url")]
        public string ForumUrl { get; set; }
    }
}