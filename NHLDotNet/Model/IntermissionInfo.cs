using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class IntermissionInfo
    {
        [JsonProperty("intermissionTimeRemaining")]
        public int IntermissionTimeRemaining { get; set; }

        [JsonProperty("intermissionTimeElapsed")]
        public int IntermissionTimeElapsed { get; set; }

        [JsonProperty("inIntermission")]
        public bool inIntermission { get; set; }
    }
}