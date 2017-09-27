using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Venue
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("timeZone")]
        public TimeZone TimeZone { get; set; }
    }
}