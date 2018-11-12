using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Person
{
    public class Person
    {
        [JsonProperty(PropertyName = "mal_id")]
        public int? MalId { get; set; }

        [JsonProperty(PropertyName = "url")] public string Url { get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "web_url")]
        public string WebUrl { get; set; }

        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        [JsonProperty(PropertyName = "given_name")]
        public string GivenName { get; set; }

        [JsonProperty(PropertyName = "family_name")]
        public string FamilyName { get; set; }

        [JsonProperty(PropertyName = "alternate_name")]
        public ICollection<string> AlternativeName { get; set; }

        [JsonProperty(PropertyName = "birthday")]
        public DateTime? Birthday { get; set; }

        [JsonProperty(PropertyName = "member_favorites")]
        public int? MemberFavorites { get; set; }

        [JsonProperty(PropertyName = "about")] public string About { get; set; }

        [JsonProperty(PropertyName = "voice_acting_roles")]
        public ICollection<VoiceActingRole> VoiceActingRoles { get; set; }

        [JsonProperty(PropertyName = "anime_staff_positions")]
        public ICollection<AnimeStaffPosition> AnimeStaffPositions { get; set; }

        [JsonProperty(PropertyName = "published_manga")]
        public ICollection<PublishedManga> PublishedMangas { get; set; }
    }
}