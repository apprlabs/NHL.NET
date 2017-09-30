// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a period
    /// </summary>
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