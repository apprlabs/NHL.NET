using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class ShootoutInfo
    {
        [JsonProperty("home")]
        public ShootoutInfoTeam Home { get; set; }

        [JsonProperty("away")]
        public ShootoutInfoTeam Away { get; set; }
    }
}