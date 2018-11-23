using System.Collections.Generic;
using JikanClient.Models.Character;
using Newtonsoft.Json;

namespace JikanClient.Models.Top
{
    public class TopCharacterItem
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "name_kanji")]
        public string NameKanji { get; set; }

        [JsonProperty(PropertyName = "animeography")]
        public ICollection<Animeography> Animeographies { get; set; }

        [JsonProperty(PropertyName = "mangaography")]
        public ICollection<Mangaography> Mangaographies { get; set; }
    }
}