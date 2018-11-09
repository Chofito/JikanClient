using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class StaffEntry
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "positions")]
        public ICollection<string> Positions { get; set; }
    }
}