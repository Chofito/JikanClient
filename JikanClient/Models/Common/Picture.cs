using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class Picture
    {
        [JsonProperty(PropertyName = "large")]
        public string Large { get; set; }

        [JsonProperty(PropertyName = "small")]
        public string Small { get; set; }
    }
}