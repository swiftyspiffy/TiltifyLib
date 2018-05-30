using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiltifyLib.Models
{
    public class Donation
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; protected set; }
        [JsonProperty(PropertyName = "amount")]
        public double Amount { get; protected set; }
        [JsonProperty(PropertyName = "currency_code")]
        public string CurrencyCode { get; protected set; }
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; protected set; }
        [JsonProperty(PropertyName = "reward")]
        public string Reward { get; protected set; }
        [JsonProperty(PropertyName = "reward_ird")]
        public string RewardId { get; protected set; }
        [JsonProperty(PropertyName = "challenge")]
        public string Challenge { get; protected set; }
        [JsonProperty(PropertyName = "challenge_id")]
        public string ChallengeId { get; protected set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }
    }
}
