using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiltifyLib.Models
{
    public class Level
    {
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; protected set; }
        [JsonProperty(PropertyName = "Amount")]
        public double Amount { get; protected set; }
    }
}
