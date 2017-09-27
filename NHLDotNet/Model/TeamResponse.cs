using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class TeamResponse
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
        
        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }
    }
}