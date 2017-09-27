using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class LineScore
    {
        [JsonProperty("franchiseId")]
        public int FranchiseId { get; set; }

        [JsonProperty("firstSeasonId")]
        public int FirstSeasonId { get; set; }

        [JsonProperty("mostRecentTeamId")]
        public int MostRecentTeamId { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }
        
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}