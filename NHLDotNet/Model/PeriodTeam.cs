// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class PeriodTeam
    {
        [JsonProperty("goals")]
        public int Goals { get; set; }

        [JsonProperty("shotsOnGoal")]
        public int ShotsOnGoal { get; set; }

        [JsonProperty("rinkSide")]
        public string RinkSide { get; set; }
    }
}