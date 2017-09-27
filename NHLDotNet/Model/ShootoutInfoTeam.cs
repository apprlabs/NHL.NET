using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class ShootoutInfoTeam
    {
        [JsonProperty("scores")]
        public int Scores { get; set; }

        [JsonProperty("attempts")]
        public int Attempts { get; set; }
    }
}