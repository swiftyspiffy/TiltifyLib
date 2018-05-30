using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiltifyLib.Models
{
    public class Campaign
    {
        [JsonProperty(PropertyName = "campaign_id")]
        public string CampaignId { get; protected set; }
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; protected set; }
        [JsonProperty(PropertyName = "mission")]
        public string Mission { get; protected set; }
        [JsonProperty(PropertyName = "owner_img")]
        public string OwnerImg { get; protected set; }
        [JsonProperty(PropertyName = "campaign")]
        public string CampaignName { get; protected set; }
        [JsonProperty(PropertyName = "cause")]
        public string Cause { get; protected set; }
        [JsonProperty(PropertyName = "cause_logo_url")]
        public string CauseLogoUrl { get; protected set; }
        [JsonProperty(PropertyName = "donation_url")]
        public string DonationUrl { get; protected set; }
        [JsonProperty(PropertyName = "campaign_url")]
        public string CampaignUrl { get; protected set; }
        [JsonProperty(PropertyName = "banner_url")]
        public string BannerUrl { get; protected set; }
        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; protected set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; protected set; }
        [JsonProperty(PropertyName = "goal")]
        public string Goal { get; protected set; }
        [JsonProperty(PropertyName = "total_raised")]
        public string TotalRaised { get; protected set; }
        [JsonProperty(PropertyName = "percent_raised")]
        public string PercentRaised { get; protected set; }
        [JsonProperty(PropertyName = "top_donor")]
        public string TopDonor { get; protected set; }
        [JsonProperty(PropertyName = "top_donor_amount")]
        public string TopDonorAmount { get; protected set; }
        [JsonProperty(PropertyName = "starts")]
        public DateTime Starts { get; protected set; }
        [JsonProperty(PropertyName = "ends")]
        public DateTime Ends { get; protected set; }
        [JsonProperty(PropertyName = "currency_code")]
        public string CurrencyCode { get; protected set; }
        [JsonProperty(PropertyName = "levels")]
        public Level[] Levels { get; protected set; }
        [JsonProperty(PropertyName = "activities")]
        public Activity[] Activities { get; protected set; }
        [JsonProperty(PropertyName = "supporting_parent_name")]
        public string SupportingParentName { get; protected set; }
        [JsonProperty(PropertyName = "donations")]
        public Donation[] Donations { get; protected set; }
    }
}
