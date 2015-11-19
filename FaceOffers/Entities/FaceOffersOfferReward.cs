using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersOfferReward
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("OfferId")]
        public Guid OfferId { get; set; }

        [JsonProperty("Reward")]
        public string Reward { get; set; }

        [JsonProperty("RewardDescription")]
        public string RewardDescription { get; set; }

        [JsonProperty("Sharing")]
        public bool Sharing { get; set; }

        [JsonProperty("SharingFrequency")]
        public string SharingFrequency { get; set; }

        [JsonProperty("Redemption")]
        public bool Redemption { get; set; }

        [JsonProperty("RedemptionFrequency")]
        public string RedemptionFrequency { get; set; }
    }
}
