using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersOfferLocation
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("OfferId")]
        public Guid? OfferId { get; set; }

        [JsonProperty("MerchantLocationId")]
        public Guid? MerchantLocationId { get; set; }
    }
}
