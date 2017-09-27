using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class LineScoreTeam
    {
        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("goals")]
        public int Goals { get; set; }

        [JsonProperty("shotsOnGoal")]
        public int ShotsOnGoal { get; set; }

        [JsonProperty("goaliePulled")]
        public bool GoaliePulled { get; set; }

        [JsonProperty("numSkaters")]
        public int NumSkaters { get; set; }

        [JsonProperty("powerPlay")]
        public bool PowerPlay { get; set; }
    }
}