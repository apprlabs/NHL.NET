using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Teams
    {
        [JsonProperty("away")]
        public GameTeam Away { get; set; }

        [JsonProperty("home")]
        public GameTeam Home { get; set; }
    }
}