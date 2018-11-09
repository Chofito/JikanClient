using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Manga
{
    public class MangaNews
    {
        [JsonProperty(PropertyName = "articles")]
        public ICollection<News> Articles { get; set; }
    }
}