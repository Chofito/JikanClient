using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Search
{
    public class CharacterSearchEntry : ItemMeta
    {
        [JsonProperty(PropertyName = "alternative_names")]
        public ICollection<string> AlternativeNames { get; set; }

        [JsonProperty(PropertyName = "anime")]
        public ICollection<MalBasicItem> Animes { get; set; }

        [JsonProperty(PropertyName = "manga")]
        public ICollection<MalBasicItem> Mangas { get; set; }
    }
}
