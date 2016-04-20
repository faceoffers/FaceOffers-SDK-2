using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersOffer
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("MerchantId")]
        public Guid MerchantId { get; set; }

        [JsonProperty("AppId")]
        public Guid AppId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Type")]
        public OfferType Type { get; set; }

        [JsonProperty("Reward")]
        public string Reward { get; set; }

        [JsonProperty("TermsConditions")]
        public string TermsConditions { get; set; }

        [JsonProperty("Tags")]
        public string Tags { get; set; }

        [JsonProperty("Limited")]
        public bool Limited { get; set; }

        [JsonProperty("RedemptionLimit")]
        public int RedemptionLimit { get; set; }

        [JsonProperty("StartDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("EndDate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("Redemption Expiration")]
        public DateTime? ExpiryDate { get; set; }

        [JsonProperty("Created")]
        public DateTime Created { get; set; }

        [JsonProperty("OfferImage")]
        public string OfferImage { get; set; }

        [JsonProperty("Published")]
        public bool Published { get; set; }

        [JsonProperty("PortalBased")]
        public bool? PortalBased { get; set; }
    }
}
