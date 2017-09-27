using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class LineScoreTeams
    {
        [JsonProperty("away")]
        public LineScoreTeam Away { get; set; }

        [JsonProperty("home")]
        public LineScoreTeam Home { get; set; }
    }
}