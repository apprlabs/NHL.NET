// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the boxscore from a game
    /// </summary>
    public class BoxScore
    {
        [JsonProperty("officials")]
        public List<Official> Officials { get; set; }

        [JsonProperty("teams")]
        public BoxScoreTeams Teams { get; set; }
    }
}