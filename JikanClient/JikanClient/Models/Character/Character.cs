using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Character
{
    public class Character
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        [JsonProperty(PropertyName = "name_kanji")]
        public string NameKanji { get; set; }

        [JsonProperty(PropertyName = "nicknames")]
        public ICollection<string> Nicknames { get; set; }

        [JsonProperty(PropertyName = "about")] public string About { get; set; }

        [JsonProperty(PropertyName = "member_favorites")]
        public int? MemberFavorites { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "animeography")]
        public ICollection<Animeography> Animeographies { get; set; }

        [JsonProperty(PropertyName = "mangaography")]
        public ICollection<Mangaography> Mangaographies { get; set; }

        [JsonProperty(PropertyName = "voice_actors")]
        public ICollection<VoiceActor> VoiceActors { get; set; }
    }
}