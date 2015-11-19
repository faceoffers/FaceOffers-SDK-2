using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersMerchant
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("PlanId")]
        public Guid? PlanId { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("UserId")]
        public string UserId { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }
    }
}
