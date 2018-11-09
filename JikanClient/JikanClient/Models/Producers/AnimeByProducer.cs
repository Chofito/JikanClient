using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Producers
{
    public class AnimeByProducer
    {
        [JsonProperty(PropertyName = "meta")] public MalBasicItem Description { get; set; }

        [JsonProperty(PropertyName = "anime")] public ICollection<AnimeBasic> Animes { get; set; }
    }
}