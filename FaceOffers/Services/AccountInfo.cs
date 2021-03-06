﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffersSDK
{
    public class AccountInfo
    {
        [JsonProperty("Succeeded")]
        public bool Succeeded { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("MerchantId")]
        public Guid MerchantId { get; set; }
    }
}
