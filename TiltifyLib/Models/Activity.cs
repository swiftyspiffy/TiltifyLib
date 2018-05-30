using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiltifyLib.Models
{
    public class Activity
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }
        [JsonProperty(PropertyName = "starts_at")]
        public DateTime StartsAt { get; protected set; }
        [JsonProperty(PropertyName = "ends_at")]
        public DateTime EndsAt { get; protected set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; protected set; }
        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; protected set; }
    }
}
