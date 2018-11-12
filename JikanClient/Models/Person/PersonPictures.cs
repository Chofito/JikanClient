using System.Collections.Generic;
using JikanClient.Models.Common;
using Newtonsoft.Json;

namespace JikanClient.Models.Person
{
    public class PersonPictures
    {
        [JsonProperty(PropertyName = "pictures")]
        public ICollection<Picture> Pictures { get; set; }
    }
}