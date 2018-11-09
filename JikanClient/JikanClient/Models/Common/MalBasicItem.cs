using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class MalBasicItem
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int MalId { get; set; }

        [JsonProperty(PropertyName = "type")] public string Type { get; set; }

        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}