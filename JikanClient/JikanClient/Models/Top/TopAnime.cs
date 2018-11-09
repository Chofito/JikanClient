using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Top
{
    public class TopAnime
    {
        [JsonProperty(PropertyName = "top")] public ICollection<TopAnimeItem> Top { get; set; }
    }
}