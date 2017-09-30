// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a details for play
    /// </summary>
    public class PlayDetails
    {
        [JsonProperty("eventIdx")]
        public long EventIdx { get; set; }

        [JsonProperty("eventId")]
        public long EventId { get; set; }

        [JsonProperty("period")]
        public long Period { get; set; }

        [JsonProperty("periodType")]
        public string PeriodType { get; set; }

        [JsonProperty("ordinalNum")]
        public string OrdinalNum { get; set; }

        [JsonProperty("periodTime")]
        public string PeriodTime { get; set; }

        [JsonProperty("periodTimeRemaining")]
        public string PeriodTimeRemaining { get; set; }

        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        [JsonProperty("goals")]
        public PlayGoals Goals { get; set; }
    }
}