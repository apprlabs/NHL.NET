// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents stats for a skater
    /// </summary>
    public class SkaterStats
    {
        [JsonProperty("timeOnIce")]
        public string TimeOnIce { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("goals")]
        public long Goals { get; set; }

        [JsonProperty("shots")]
        public long Shots { get; set; }
        
        [JsonProperty("hits")]
        public long Hits { get; set; }

        [JsonProperty("powerPlayGoals")]
        public long PowerPlayGoals { get; set; }

        [JsonProperty("powerPlayAssists")]
        public long PowerPlayAssists { get; set; }

        [JsonProperty("penaltyMinutes")]
        public long PenaltyMinutes { get; set; }

        [JsonProperty("faceOffPct")]
        public long? FaceOffPct { get; set; }

        [JsonProperty("faceOffWins")]
        public long FaceOffWins { get; set; }

        [JsonProperty("faceoffTaken")]
        public long FaceoffTaken { get; set; }

        [JsonProperty("takeaways")]
        public long Takeaways { get; set; }

        [JsonProperty("giveaways")]
        public long Giveaways { get; set; }

        [JsonProperty("shortHandedGoals")]
        public long ShortHandedGoals { get; set; }

        [JsonProperty("shortHandedAssists")]
        public long ShortHandedAssists { get; set; }

        [JsonProperty("blocked")]
        public long Blocked { get; set; }

        [JsonProperty("plusMinus")]
        public double PlusMinus { get; set; }

        [JsonProperty("evenTimeOnIce")]
        public string EvenTimeOnIce { get; set; }

        [JsonProperty("powerPlayTimeOnIce")]
        public string PowerPlayTimeOnIce { get; set; }

        [JsonProperty("shortHandedTimeOnIce")]
        public string ShortHandedTimeOnIce { get; set; }
    }
}