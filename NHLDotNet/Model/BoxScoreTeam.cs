// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents team in a box score
    /// </summary>
    public class BoxScoreTeam
    {
        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("teamStats")]
        public TeamStats TeamStats { get; set; }

        [JsonProperty("players")]
        public Dictionary<string, BoxScorePlayer> Players { get; set; }

        [JsonProperty("goalies")]
        public List<int> Goalies { get; set; }

        [JsonProperty("skaters")]
        public List<int> Skaters { get; set; }

        [JsonProperty("onIce")]
        public List<int> OnIce { get; set; }

        [JsonProperty("onIcePlus")]
        public List<OnIcePlus> OnIcePlus { get; set; }

        [JsonProperty("scratches")]
        public List<int> Scratches { get; set; }

        // [JsonProperty("penaltyBox")]
        // public object[] PenaltyBox { get; set; }

        [JsonProperty("coaches")]
        public List<Coach> Coaches { get; set; }
    }
}