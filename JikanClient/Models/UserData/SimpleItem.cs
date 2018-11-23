using Newtonsoft.Json;

namespace JikanClient.Models.UserData
{
    public class SimpleItem
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}