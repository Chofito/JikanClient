using Newtonsoft.Json;

namespace JikanClient.Models.AnimeData
{
    public class EpisodeVideo
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "episode")]
        public string Episode { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }
    }
}