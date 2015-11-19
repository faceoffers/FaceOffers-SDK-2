using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersSharedOfferSummaryOptions
    {
        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("OfferName")]
        public string OfferName { get; set; }

        [JsonProperty("Redeemed")]
        public bool Redeemed { get; set; }

        [JsonProperty("ShareDate")]
        public DateTime ShareDate { get; set; }
    }
}
