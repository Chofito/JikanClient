using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Search
{
    public class PersonSearchResult
    {
        [JsonProperty(PropertyName = "results")]
        public ICollection<PersonSearchEntry> SearchResults { get; set; }
    }
}
