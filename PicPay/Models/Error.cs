﻿using Newtonsoft.Json;

namespace PicPay.Models
{
    public class Error
    {
        [JsonProperty("field", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Field { get; set; }
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; set; }
    }
}