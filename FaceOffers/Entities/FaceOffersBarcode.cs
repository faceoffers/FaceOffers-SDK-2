using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class FaceOffersBarcode
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Type")]
        public int? Type { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }
    }
}
