using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Date
    {
        [JsonProperty("date")]
        public string DateString { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("totalEvents")]
        public int TotalEvents { get; set; }

        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }

        [JsonProperty("totalMatches")]
        public int TotalMatches { get; set; }

        [JsonProperty("games")]
        public List<Game> Games { get; set; }

        // [JsonProperty("events")]
        // public List<object> Events { get; set; }

        // [JsonProperty("matches")]
        // public List<object> Matches { get; set; }
    }
}