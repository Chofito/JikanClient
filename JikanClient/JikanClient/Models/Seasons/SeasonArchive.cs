using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Seasons
{
    public class SeasonArchive
    {
        [JsonProperty(PropertyName = "archive")]
        public ICollection<SeasonList> Archives { get; set; }
    }
}