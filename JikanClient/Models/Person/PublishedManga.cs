using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Person
{
    public class PublishedManga
    {
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "manga")]
        public ICollection<MangaMeta> Mangas { get; set; }
    }
}