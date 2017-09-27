using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class TimeZone
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("tz")]
        public string TZ { get; set; }
    }
}