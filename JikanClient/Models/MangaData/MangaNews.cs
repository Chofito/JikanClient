using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.MangaData
{
    public class MangaNews
    {
        [JsonProperty(PropertyName = "articles")]
        public ICollection<News> Articles { get; set; }
    }
}