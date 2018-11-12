using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class AnimeForum
    {
        [JsonProperty(PropertyName = "topics")]
        public ICollection<Topic> Topics { get; set; }
    }
}