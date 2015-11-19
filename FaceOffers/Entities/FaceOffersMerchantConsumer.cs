using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersMerchantConsumer
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("ConsumerId")]
        public Guid ConsumerId { get; set; }

        [JsonProperty("MerchantLocationId")]
        public Guid MerchantLocationId { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }
    }
}
