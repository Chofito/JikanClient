using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class Ography : ItemMeta
    {
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }
    }
}