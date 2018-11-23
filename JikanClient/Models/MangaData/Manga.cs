using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.MangaData
{
    public class Manga
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "title_english")]
        public string TitleEnglish { get; set; }

        [JsonProperty(PropertyName = "title_synonyms")]
        public ICollection<string> TitleSynonyms { get; set; }

        [JsonProperty(PropertyName = "title_japanese")]
        public string TitleJapanese { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "volumes")]
        public int? Volumes { get; set; }

        [JsonProperty(PropertyName = "chapters")]
        public int? Chapters { get; set; }

        [JsonProperty(PropertyName = "publishing")]
        public bool? Publishing { get; set; }

        [JsonProperty(PropertyName = "published")]
        public TimePeriod Published { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        [JsonProperty(PropertyName = "score")]
        public float? Score { get; set; }

        [JsonProperty(PropertyName = "scored_by")]
        public int? ScoredBy { get; set; }

        [JsonProperty(PropertyName = "popularity")]
        public int? Popularity { get; set; }

        [JsonProperty(PropertyName = "members")]
        public int? Members { get; set; }

        [JsonProperty(PropertyName = "favorites")]
        public int? Favorites { get; set; }

        [JsonProperty(PropertyName = "synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty(PropertyName = "background")]
        public string Background { get; set; }

        [JsonProperty(PropertyName = "related")]
        public Related Related { get; set; }

        [JsonProperty(PropertyName = "genres")]
        public ICollection<MalBasicItem> Genres { get; set; }

        [JsonProperty(PropertyName = "authors")]
        public ICollection<MalBasicItem> Authors { get; set; }

        [JsonProperty(PropertyName = "serializations")]
        public ICollection<MalBasicItem> Serializations { get; set; }
    }
}