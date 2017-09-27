using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Status
    {
        [JsonProperty("abstractGameState")]
        public string AbstractGameState { get; set; }

        [JsonProperty("codedGameState")]
        public string CodedGameState { get; set; }

        [JsonProperty("detailedState")]
        public string DetailedState { get; set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("startTimeTBD")]
        public bool StartTimeTBD { get; set; }
    }
}