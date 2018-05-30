using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TiltifyLib.Enums;
using TiltifyLib.Models;

namespace TiltifyLib
{
    public class Core
    {
        private const string apiBase = "https://tiltify.com/api/v2/";

        private HttpClient client;
        private Dictionary<string, string> apiSuffix = new Dictionary<string, string>() { { "campaign", "campaign" }, { "donations", "/campaign/donations" }, { "rewards", "/campaign/rewards" }, { "levels", "/campaign/levels" }, { "activities", "/campaign/activities" } };

        public Core(string apiKey)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", $"token=\"{apiKey}\"");
        }

        public async Task<Campaign> GetCampaignAsync(bool? donations = null, int? donationLimit = null, DonationOrderBy donationOrderBy = DonationOrderBy.Date, DonationOrder? donationOrder = null)
        {
            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>();
            if (donations != null)
                args.Add(new KeyValuePair<string, string>("donations", donations.ToString().ToLower()));
            if (donationLimit != null)
                args.Add(new KeyValuePair<string, string>("donation_limit", donationLimit.ToString()));
            args.Add(new KeyValuePair<string, string>("donation_order_by", (donationOrderBy == DonationOrderBy.Date ? "date" : "amount")));
            if (donationOrder != null)
                args.Add(new KeyValuePair<string, string>("donation_order", (donationOrder == DonationOrder.Ascending ? "asc" : "desc")));

            string argsStr = buildArgs(args);
            string endpoint = $"{apiBase}{apiSuffix["campaign"]}{argsStr}";

            return await performRequest<Campaign>(endpoint);
        }

        public async Task<Reward[]> GetRewardsAsync()
        {
            string endpoint = $"{apiBase}{apiSuffix["rewards"]}";
            return await performRequest<Reward[]>(endpoint);
        }

        public async Task<Donation[]> GetDonationsAsync(int? donationLimit = null, DonationOrderBy donationOrderBy = DonationOrderBy.Date, DonationOrder? donationOrder = null)
        {
            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>();
            if (donationLimit != null)
                args.Add(new KeyValuePair<string, string>("donation_limit", donationLimit.ToString()));
            args.Add(new KeyValuePair<string, string>("donation_order_by", (donationOrderBy == DonationOrderBy.Date ? "date" : "amount")));
            if (donationOrder != null)
                args.Add(new KeyValuePair<string, string>("donation_order", (donationOrder == DonationOrder.Ascending ? "asc" : "desc")));

            string argsStr = buildArgs(args);
            string endpoint = $"{apiBase}{apiSuffix["donations"]}{argsStr}";

            return await performRequest<Donation[]>(endpoint);
        }

        public async Task<Level[]> GetLevelsAsync()
        {
            string endpoint = $"{apiBase}{apiSuffix["levels"]}";
            return await performRequest<Level[]>(endpoint);
        }

        public async Task<Activity[]> GetActivitiesAsync()
        {
            string endpoint = $"{apiBase}{apiSuffix["activities"]}";
            return await performRequest<Activity[]>(endpoint);
        }

        private async Task<T> performRequest<T>(string endpoint)
        {
            string jsonStr = await client.GetStringAsync(endpoint);
            return JsonConvert.DeserializeObject<T>(jsonStr);
        }

        private string buildArgs(List<KeyValuePair<string, string>> args)
        {
            string argsStr = "";
            foreach(var arg in args)
            {
                if (argsStr == "")
                    argsStr = $"?{arg.Key}={arg.Value}";
                else
                    argsStr += $"&{arg.Key}={arg.Value}";
            }
            return argsStr;
        }
    }
}
