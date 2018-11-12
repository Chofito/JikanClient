using System.Collections.Generic;
using JikanClient.Models.Character;
using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class AnimeCharactersAndStaff
    {
        [JsonProperty(PropertyName = "characters")]
        public ICollection<CharacterEntry> Characters { get; set; }

        [JsonProperty(PropertyName = "Staff")] public ICollection<StaffEntry> Staff { get; set; }
    }
}