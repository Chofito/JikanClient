using Newtonsoft.Json;

namespace JikanClient.Models.Character
{
    public class CharacterMangaEntry
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "Name")] public string Name { get; set; }

        [JsonProperty(PropertyName = "role")] public string Role { get; set; }
    }
}