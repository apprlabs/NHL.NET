// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the live data from a game feed
    /// </summary>
    public class LiveData
    {
        [JsonProperty("plays")]
        public Plays Plays { get; set; }

        [JsonProperty("linescore")]
        public LineScore Linescore { get; set; }

        [JsonProperty("boxscore")]
        public BoxScore BoxScore { get; set; }

        [JsonProperty("decisions")]
        public Decisions Decisions { get; set; }
    }
}