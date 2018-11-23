using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Person
{
    public class AnimeStaffPosition
    {
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "anime")]
        public ICollection<AnimeMeta> Animes { get; set; }
    }
}