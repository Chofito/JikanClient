using System;
using Newtonsoft.Json;

namespace JikanClient.Models.Top
{
    public class TopPeopleItem
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "rank")] public int? Rank { get; set; }

        [JsonProperty(PropertyName = "title")] public string Title { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "name_kanji")]
        public string NameKanji { get; set; }

        [JsonProperty(PropertyName = "favorites")]
        public int? Favrites { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "birthday")]
        public DateTime? Birthday { get; set; }
    }
}