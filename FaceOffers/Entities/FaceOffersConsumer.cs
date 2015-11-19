using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersConsumer
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Address1")]
        public string Address1 { get; set; }

        [JsonProperty("Address2")]
        public string Address2 { get; set; }

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
