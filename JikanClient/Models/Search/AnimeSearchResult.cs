using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Search
{
    public class AnimeSearchResult
    {
        [JsonProperty(PropertyName = "results")]
        public ICollection<AnimeSearchEntry> SearchResults { get; set; }
    }
}
