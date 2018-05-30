using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiltifyLib.Models
{
    public class Challenge
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; protected set; }
        [JsonProperty(PropertyName = "total_raised")]
        public string TotalRaised { get; protected set; }
        [JsonProperty(PropertyName = "activated_at")]
        public DateTime ActivatedAt { get; protected set; }
        [JsonProperty(PropertyName = "ends_at")]
        public DateTime EndsAt { get; protected set; }
    }
}
