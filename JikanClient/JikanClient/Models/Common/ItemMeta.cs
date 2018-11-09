using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public abstract class ItemMeta
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
    }
}