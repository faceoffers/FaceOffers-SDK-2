using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersApp
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("MerchantId")]
        public Guid MerchantId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Created")]
        public DateTime Created { get; set; }

        [JsonProperty("Modified")]
        public DateTime? Modified { get; set; }

        [JsonProperty("Photo")]
        public string Photo { get; set; }

        [JsonProperty("KeyId")]
        public Guid KeyId { get; set; }
    }
}
