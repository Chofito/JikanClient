using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Common
{
    public class Related
    {
        [JsonProperty(PropertyName = "Adaptation")]
        public ICollection<MalBasicItem> Adaptations { get; set; }

        [JsonProperty(PropertyName = "Alternative Version")]
        public ICollection<MalBasicItem> AlternativeVersions { get; set; }

        [JsonProperty(PropertyName = "Character")]
        public ICollection<MalBasicItem> Characters { get; set; }

        [JsonProperty(PropertyName = "Other")]
        public ICollection<MalBasicItem> Others { get; set; }

        [JsonProperty(PropertyName = "Prequel")]
        public ICollection<MalBasicItem> Prequels { get; set; }

        [JsonProperty(PropertyName = "Sequel")]
        public ICollection<MalBasicItem> Sequels { get; set; }

        [JsonProperty(PropertyName = "Side Store")]
        public ICollection<MalBasicItem> SideStories { get; set; }

        [JsonProperty(PropertyName = "Spin-Off")]
        public ICollection<MalBasicItem> SpinOffs { get; set; }

        [JsonProperty(PropertyName = "Summary")]
        public ICollection<MalBasicItem> Summaries { get; set; }
    }
}