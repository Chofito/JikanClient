using Newtonsoft.Json;

namespace JikanClient.Models.MangaData
{
    public class MangaMoreInfo
    {
        [JsonProperty(PropertyName = "more_info")]
        public string MoreInfo { get; set; }
    }
}