using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class Anime
    {
        #region Anime Basic Info

        [JsonProperty(PropertyName = "mal_id")]
        public int MalId { get; set; }

        [JsonProperty(PropertyName = "url")] 
        public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "trailer_url")]
        public string TrailerUrl { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "title_english")]
        public string TitleEnglish { get; set; }

        [JsonProperty(PropertyName = "title_japanese")]
        public string TitleJapanese { get; set; }

        [JsonProperty(PropertyName = "title_synonyms")]
        public ICollection<string> TitleSynonyms { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "episodes")]
        public int? Episodes { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "airing")]
        public bool? Airing { get; set; }

        [JsonProperty(PropertyName = "aired")]
        public TimePeriod Aired { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public string Rating { get; set; }

        [JsonProperty(PropertyName = "score")]
        public float? Score { get; set; }

        [JsonProperty(PropertyName = "scored_by")]
        public int? ScoredBy { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

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

        [JsonProperty(PropertyName = "premiered")]
        public string Premiered { get; set; }

        [JsonProperty(PropertyName = "broadcast")]
        public string Broadcast { get; set; }

        [JsonProperty(PropertyName = "related")]
        public Related Related { get; set; }

        [JsonProperty(PropertyName = "producers")]
        public ICollection<Producer> Producers { get; set; }

        [JsonProperty(PropertyName = "licensors")]
        public ICollection<Licensor> Licensors { get; set; }

        [JsonProperty(PropertyName = "studios")]
        public ICollection<Studio> Studios { get; set; }

        [JsonProperty(PropertyName = "genres")]
        public ICollection<Genre> Genres { get; set; }

        [JsonProperty(PropertyName = "opening_themes")]
        public ICollection<string> OpeningThemes { get; set; }

        [JsonProperty(PropertyName = "ending_themes")]
        public ICollection<string> EndingThemes { get; set; }

        #endregion
    }
}