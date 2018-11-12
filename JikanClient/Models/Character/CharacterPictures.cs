using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Character
{
    public class CharacterPictures
    {
        [JsonProperty(PropertyName = "pictures")]
        public ICollection<Picture> Pictures { get; set; }
    }
}