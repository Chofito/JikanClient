using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Magazines
{
    public class MangaByMagazine
    {
        [JsonProperty(PropertyName = "meta")] public MalBasicItem Description { get; set; }

        [JsonProperty(PropertyName = "manga")] public ICollection<MangaBasic> Mangas { get; set; }
    }
}