using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersMerchantDeveloper
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("MerchantId")]
        public Guid MerchantId { get; set; }

        [JsonProperty("UserId")]
        public Guid UserId { get; set; }
    }
}
