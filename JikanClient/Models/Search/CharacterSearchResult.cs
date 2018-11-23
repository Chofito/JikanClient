using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Search
{
    public class CharacterSearchResult
    {
        [JsonProperty(PropertyName = "results")]
        public ICollection<CharacterSearchEntry> Results { get; set; }
    }
}
