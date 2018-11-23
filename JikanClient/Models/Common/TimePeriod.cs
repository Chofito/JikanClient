using System;
using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class TimePeriod
    {
        [JsonProperty(PropertyName = "from")]
        public DateTime? From { get; set; }

        [JsonProperty(PropertyName = "to")]
        public DateTime? To { get; set; }

        [JsonProperty(PropertyName = "string")]
        public string TimePeriodString { get; set; }

        public override string ToString()
        {
            return TimePeriodString ?? base.ToString();
        }
    }
}