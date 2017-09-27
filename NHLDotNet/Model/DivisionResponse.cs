using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class DivisionResponse
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
        
        [JsonProperty("divisions")]
        public List<Division> Divisions { get; set; }
    }
}