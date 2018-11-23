using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Search
{
    public class PersonSearchEntry : ItemMeta
    {
        [JsonProperty(PropertyName = "alternative_names")]
        public ICollection<string> AlternativeNames { get; set; }
    }
}
