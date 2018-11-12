using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Anime
{
    public class AnimePictures
    {
        [JsonProperty(PropertyName = "pictures")]
        public ICollection<Picture> Pictures { get; set; }
    }
}