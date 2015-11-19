using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersSharedOffer
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("FromConsumerId")]
        public Guid? FromConsumerId { get; set; }

        [JsonProperty("ToConsumerId")]
        public Guid? ToConsumerId { get; set; }

        [JsonProperty("OfferId")]
        public Guid OfferId { get; set; }

        [JsonProperty("Redeemed")]
        public bool? Redeemed { get; set; }

        [JsonProperty("Timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
