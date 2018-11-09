using System;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.User
{
    public class History
    {
        [JsonProperty(PropertyName = "meta")] public MalBasicItem Element { get; set; }

        [JsonProperty(PropertyName = "increment")]
        public int? Increment { get; set; }

        [JsonProperty(PropertyName = "date")] public DateTime? Date { get; set; }
    }
}