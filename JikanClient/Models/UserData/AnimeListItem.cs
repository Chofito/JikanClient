using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.UserData
{
    public class AnimeListItem
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "watching_status")]
        public int? WatchingStatus { get; set; }

        [JsonProperty(PropertyName = "score")]
        public float? Score { get; set; }

        [JsonProperty(PropertyName = "watched_episodes")]
        public int? WatchedEpisodes { get; set; }

        [JsonProperty(PropertyName = "total_episodes")]
        public int? TotalEpisodes { get; set; }

        [JsonProperty(PropertyName = "airing_status")]
        public int? AiringStatus { get; set; }

        [JsonProperty(PropertyName = "season_name")]
        public string SeasonName { get; set; }

        [JsonProperty(PropertyName = "season_year")]
        public int? SeasonYear { get; set; }

        [JsonProperty(PropertyName = "has_episode_video")]
        public bool? HasEpisodeVideo { get; set; }

        [JsonProperty(PropertyName = "has_promo_video")]
        public bool? HasPromoVideo { get; set; }

        [JsonProperty(PropertyName = "has_video")]
        public bool HasVideo { get; set; }

        [JsonProperty(PropertyName = "is_rewatching")]
        public bool IsRewatching { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public ICollection<string> Tags { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public string Rating { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "end_date")]
        public DateTime? EndDate { get; set; }

        [JsonProperty(PropertyName = "watch_start_date")]
        public DateTime? WatchStartDate { get; set; }

        [JsonProperty(PropertyName = "watch_end_date")]
        public DateTime? WatchEndDate { get; set; }

        [JsonProperty(PropertyName = "days")]
        public ICollection<string> Days { get; set; }

        [JsonProperty(PropertyName = "storage")]
        public ICollection<string> Storage { get; set; }

        [JsonProperty(PropertyName = "priority")]
        public string Priority { get; set; }

        [JsonProperty(PropertyName = "added_to_list")]
        public bool AddedToList { get; set; }

        [JsonProperty(PropertyName = "studios")]
        public ICollection<SimpleItem> Studios { get; set; }

        [JsonProperty(PropertyName = "licensors")]
        public ICollection<SimpleItem> Licensors { get; set; }
    }
}