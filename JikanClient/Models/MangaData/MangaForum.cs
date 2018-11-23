using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.MangaData
{
    public class MangaForum
    {
        [JsonProperty(PropertyName = "topics")]
        public ICollection<Topic> Topics { get; set; }
    }
}