using Newtonsoft.Json;

namespace JikanClient.Models.Character
{
    public class VoiceActor
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}