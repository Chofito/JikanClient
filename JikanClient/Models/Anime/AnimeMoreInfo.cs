using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class AnimeMoreInfo
    {
        [JsonProperty(PropertyName = "more_info")]
        public string MoreInfo { get; set; }
    }
}