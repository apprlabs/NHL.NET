// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents stats for a goalie
    /// </summary>
    public class GoalieStats
    {
        [JsonProperty("timeOnIce")]
        public string TimeOnIce { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("goals")]
        public int Goals { get; set; }

        [JsonProperty("pim")]
        public int Pim { get; set; }

        [JsonProperty("shots")]
        public int Shots { get; set; }

        [JsonProperty("saves")]
        public int Saves { get; set; }

        [JsonProperty("powerPlaySaves")]
        public int PowerPlaySaves { get; set; }

        [JsonProperty("shortHandedSaves")]
        public int ShortHandedSaves { get; set; }

        [JsonProperty("evenSaves")]
        public int EvenSaves { get; set; }

        [JsonProperty("shortHandedShotsAgainst")]
        public int ShortHandedShotsAgainst { get; set; }

        [JsonProperty("evenShotsAgainst")]
        public int EvenShotsAgainst { get; set; }

        [JsonProperty("powerPlayShotsAgainst")]
        public int PowerPlayShotsAgainst { get; set; }

        [JsonProperty("savePercentage")]
        public double SavePercentage { get; set; }

        [JsonProperty("powerPlaySavePercentage")]
        public double PowerPlaySavePercentage { get; set; }

        [JsonProperty("shortHandedSavePercentage")]
        public double ShortHandedSavePercentage { get; set; }

        [JsonProperty("evenStrengthSavePercentage")]
        public double EvenStrengthSavePercentage { get; set; }
    }
}