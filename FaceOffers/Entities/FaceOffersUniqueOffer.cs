using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersUniqueOffer
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("OfferId")]
        public Guid? OfferId { get; set; }

        [JsonProperty("ConsumerId")]
        public Guid? ConsumerId { get; set; }

        [JsonProperty("BarcodeId")]
        public Guid? BarcodeId { get; set; }

        [JsonProperty("Discount")]
        public string Discount { get; set; }

        [JsonProperty("ShareDiscount")]
        public string ShareDiscount { get; set; }

        [JsonProperty("RedeemDiscount")]
        public string RedeemDiscount { get; set; }

        [JsonProperty("Timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}
