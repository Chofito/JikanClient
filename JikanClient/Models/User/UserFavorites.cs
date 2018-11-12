using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.User
{
    public class UserFavorites
    {
        [JsonProperty(PropertyName = "anime")] public ICollection<AnimeMeta> Animes { get; set; }

        [JsonProperty(PropertyName = "manga")] public ICollection<MangaMeta> Mangas { get; set; }

        [JsonProperty(PropertyName = "characters")]
        public ICollection<CharacterMeta> Characters { get; set; }

        [JsonProperty(PropertyName = "people")]
        public ICollection<PersonMeta> People { get; set; }
    }
}