using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Top
{
    public class TopCharacter
    {
        [JsonProperty(PropertyName = "top")]
        public ICollection<TopCharacterItem> Top { get; set; }
    }
}