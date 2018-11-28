using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Search
{
    public class CharacterSearchResult
    {
        [JsonProperty(PropertyName = "results")]
        public ICollection<CharacterSearchEntry> SearchResults { get; set; }
    }
}
