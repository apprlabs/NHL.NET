using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class FranchiseResponse
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
        
        [JsonProperty("franchises")]
        public List<Franchise> Franchises { get; set; }
    }
}