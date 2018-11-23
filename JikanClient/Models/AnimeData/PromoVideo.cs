using Newtonsoft.Json;

namespace JikanClient.Models.AnimeData
{
    public class PromoVideo
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "video_url")]
        public string VideoUrl { get; set; }
    }
}