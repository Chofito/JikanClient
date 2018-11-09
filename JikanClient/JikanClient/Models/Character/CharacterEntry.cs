using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Character
{
    public class CharacterEntry
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "role")] public string Role { get; set; }

        [JsonProperty(PropertyName = "voice_actors")]
        public ICollection<VoiceActor> VoiceActors { get; set; }
    }
}