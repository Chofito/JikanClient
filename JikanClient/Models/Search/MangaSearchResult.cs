using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Search
{
    public class MangaSearchResult
    {
        [JsonProperty(PropertyName = "results")]
        public ICollection<MangaSearchEntry> SearchResults { get; set; }
    }
}
