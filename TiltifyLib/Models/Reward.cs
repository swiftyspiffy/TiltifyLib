using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiltifyLib.Models
{
    public class Reward
    {
        [JsonProperty(PropertyName = "reward_id")]
        public int RewardId { get; protected set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }
        [JsonProperty(PropertyName = "amount")]
        public double Amount { get; protected set; }
        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; protected set; }
        [JsonProperty(PropertyName = "remaining")]
        public double Remaining { get; protected set; }
        [JsonProperty(PropertyName = "fmv")]
        public double FMV { get; protected set; }
        [JsonProperty(PropertyName = "starts_at")]
        public DateTime StartsAt { get; protected set; }
        [JsonProperty(PropertyName = "ends_at")]
        public DateTime EndsAt { get; protected set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; protected set; }
        [JsonProperty(PropertyName = "rules_url")]
        public string RulesUrl { get; protected set; }
        [JsonProperty(PropertyName = "shipping_address_required")]
        public bool ShippingAddressRequired { get; protected set; }
        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; protected set; }
        [JsonProperty(PropertyName = "currency_code")]
        public string CurrencyCode { get; protected set; }
        [JsonProperty(PropertyName = "donate_url")]
        public string DonateUrl { get; protected set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created { get; protected set; }
    }
}
