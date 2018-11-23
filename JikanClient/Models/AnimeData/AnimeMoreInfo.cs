using Newtonsoft.Json;

namespace JikanClient.Models.AnimeData
{
    public class AnimeMoreInfo
    {
        [JsonProperty(PropertyName = "more_info")]
        public string MoreInfo { get; set; }
    }
}