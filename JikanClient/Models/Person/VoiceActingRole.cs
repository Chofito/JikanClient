using System.Collections.Generic;
using JikanClient.Models.Character;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Person
{
    public class VoiceActingRole
    {
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = "anime")]
        public ICollection<AnimeBasic> Animes { get; set; }

        [JsonProperty(PropertyName = "character")]
        public ICollection<CharacterEntry> Characters { get; set; }
    }
}