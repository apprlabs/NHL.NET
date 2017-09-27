using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class PeriodTeam
    {
        [JsonProperty("goals")]
        public int Goals { get; set; }

        [JsonProperty("shotsOnGoal")]
        public int ShotsOnGoal { get; set; }

        [JsonProperty("rinkSide")]
        public string RinkSide { get; set; }
    }
}