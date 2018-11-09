using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Seasons
{
    public class SeasonList
    {
        [JsonProperty(PropertyName = "year")] public bool? Continuing { get; set; }

        [JsonProperty(PropertyName = "seasons")]
        public ICollection<string> Seasons { get; set; }
    }
}