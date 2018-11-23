using System.Collections.Generic;
using JikanClient.Models.Character;
using Newtonsoft.Json;

namespace JikanClient.Models.MangaData
{
    public class MangaCharacters
    {
        [JsonProperty(PropertyName = "characters")]
        public ICollection<CharacterMangaEntry> Characters { get; set; }
    }
}