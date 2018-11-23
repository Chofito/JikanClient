using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.MangaData
{
    public class MangaPictures
    {
        [JsonProperty(PropertyName = "pictures")]
        public ICollection<Picture> Pictures { get; set; }
    }
}