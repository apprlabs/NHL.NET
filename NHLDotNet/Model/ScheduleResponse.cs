using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class ScheduleResponse
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
        
        [JsonProperty("totalEvents")]
        public int TotalEvents { get; set; }
        
        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }
        
        [JsonProperty("totalMatches")]
        public int TotalMatches { get; set; }
        
        [JsonProperty("wait")]
        public int Wait { get; set; }
        
        [JsonProperty("dates")]
        public List<Date> Dates { get; set; }
    }
}