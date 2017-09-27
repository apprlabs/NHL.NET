using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Period
    {
        [JsonProperty("periodType")]
        public string PeriodType { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("ordinalNum")]
        public string OrdinalNum { get; set; }

        [JsonProperty("home")]
        public PeriodTeam Home { get; set; }

        [JsonProperty("away")]
        public PeriodTeam Away { get; set; }
    }
}