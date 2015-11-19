using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK.Services
{
    public class FaceOffersMerchantConsumerSummaryOptions
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("FullName")]
        public string FullName { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Address1")]
        public string Address1 { get; set; }

        [JsonProperty("Addresss2")]
        public string Addresss2 { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("ZipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("Image")]
        public string Image { get; set; }
    }
}
