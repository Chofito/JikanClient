using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Top
{
    public class TopManga
    {
        [JsonProperty(PropertyName = "top")]
        public ICollection<TopMangaItem> Top { get; set; }
    }
}