// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents player stats in a box score
    /// </summary>
    public class BoxScorePlayerStats
    {
        [JsonProperty("skaterStats")]
        public SkaterStats SkaterStats { get; set; }

        [JsonProperty("goalieStats")]
        public GoalieStats GoalieStats { get; set; }
    }
}