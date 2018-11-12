using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Schedule
{
    public class Schedule
    {
        [JsonProperty(PropertyName = "monday")]
        public ICollection<AnimeBasic> Monday { get; set; }

        [JsonProperty(PropertyName = "tuesday")]
        public ICollection<AnimeBasic> Tuesday { get; set; }

        [JsonProperty(PropertyName = "wednesday")]
        public ICollection<AnimeBasic> Wednesday { get; set; }

        [JsonProperty(PropertyName = "thursday")]
        public ICollection<AnimeBasic> Thursday { get; set; }

        [JsonProperty(PropertyName = "friday")]
        public ICollection<AnimeBasic> Friday { get; set; }

        [JsonProperty(PropertyName = "saturday")]
        public ICollection<AnimeBasic> Saturday { get; set; }

        [JsonProperty(PropertyName = "sunday")]
        public ICollection<AnimeBasic> Sunday { get; set; }

        [JsonProperty(PropertyName = "other")] public ICollection<AnimeBasic> Other { get; set; }

        [JsonProperty(PropertyName = "unknown")]
        public ICollection<AnimeBasic> Unknown { get; set; }
    }
}