using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class Scores
    {
        [JsonProperty(PropertyName = "1")]
        public ScoreEntry One { get; set; }

        [JsonProperty(PropertyName = "2")]
        public ScoreEntry Two { get; set; }

        [JsonProperty(PropertyName = "3")]
        public ScoreEntry Three { get; set; }

        [JsonProperty(PropertyName = "4")]
        public ScoreEntry Four { get; set; }

        [JsonProperty(PropertyName = "5")]
        public ScoreEntry Five { get; set; }

        [JsonProperty(PropertyName = "6")]
        public ScoreEntry Six { get; set; }

        [JsonProperty(PropertyName = "7")]
        public ScoreEntry Seven { get; set; }

        [JsonProperty(PropertyName = "8")]
        public ScoreEntry Eight { get; set; }

        [JsonProperty(PropertyName = "9")]
        public ScoreEntry Nine { get; set; }

        [JsonProperty(PropertyName = "10")]
        public ScoreEntry Ten { get; set; }
    }
}