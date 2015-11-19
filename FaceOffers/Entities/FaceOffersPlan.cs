using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersPlan
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("PlanName")]
        public string PlanName { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("LimitedApps")]
        public bool LimitedApps { get; set; }

        [JsonProperty("AppLimit")]
        public string AppLimit { get; set; }

        [JsonProperty("LimitedLocations")]
        public bool LimitedLocations { get; set; }

        [JsonProperty("LocationLimit")]
        public int? LocationLimit { get; set; }

        [JsonProperty("LimitedOffers")]
        public bool LimitedOffers { get; set; }

        [JsonProperty("OfferLimit")]
        public int? OfferLimit { get; set; }

        [JsonProperty("Amount")]
        public int? Amount { get; set; }

        [JsonProperty("WithCall")]
        public bool WithCall { get; set; }

        [JsonProperty("Billable")]
        public bool Billable { get; set; }
    }
}
