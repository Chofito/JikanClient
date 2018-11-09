using Newtonsoft.Json;

namespace JikanClient.Models.Manga
{
    public class MangaMoreInfo
    {
        [JsonProperty(PropertyName = "more_info")]
        public string MoreInfo { get; set; }
    }
}