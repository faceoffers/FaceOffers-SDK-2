using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK.Services
{
    public class FaceOffersOfferSummaryOptions
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("MerchantId")]
        public Guid MerchantId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Shares")]
        public int Shares { get; set; }

        [JsonProperty("Redemptions")]
        public int Redemptions { get; set; }

        [JsonProperty("Created")]
        public DateTime Created { get; set; }

        [JsonProperty("ExpiryDate")]
        public DateTime? ExpiryDate { get; set; }

        [JsonProperty("Published")]
        public bool Published { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }
    }
}
