using System.Collections.Generic;
using Newtonsoft.Json;

namespace JikanClient.Models.Top
{
    public class TopPeople
    {
        [JsonProperty(PropertyName = "top")] public ICollection<TopPeopleItem> Top { get; set; }
    }
}