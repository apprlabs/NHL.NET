// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents groups of plays in game feed
    /// </summary>
    public class Plays
    {
        [JsonProperty("allPlays")]
        public List<Play> AllPlays { get; set; }

        [JsonProperty("scoringPlays")]
        public List<int> ScoringPlays { get; set; }

        [JsonProperty("penaltyPlays")]
        public List<int> PenaltyPlays { get; set; }

        [JsonProperty("playsByPeriod")]
        public List<PlaysByPeriod> PlaysByPeriod { get; set; }

        [JsonProperty("currentPlay")]
        public Play CurrentPlay { get; set; }
    }
}