// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents team skater stats from a box score
    /// </summary>
    public class TeamSkaterStats
    {
        [JsonProperty("goals")]
        public int Goals { get; set; }

        [JsonProperty("pim")]
        public int Pim { get; set; }

        [JsonProperty("shots")]
        public int Shots { get; set; }

        [JsonProperty("powerPlayPercentage")]
        public float PowerPlayPercentage { get; set; }

        [JsonProperty("powerPlayGoals")]
        public float PowerPlayGoals { get; set; }

        [JsonProperty("powerPlayOpportunities")]
        public float PowerPlayOpportunities { get; set; }

        [JsonProperty("faceOffWinPercentage")]
        public float FaceOffWinPercentage { get; set; }

        [JsonProperty("blocked")]
        public int Blocked { get; set; }

        [JsonProperty("takeaways")]
        public int Takeaways { get; set; }

        [JsonProperty("giveaways")]
        public int Giveaways { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }
    }
}