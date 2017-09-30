// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents teams in the box score
    /// </summary>
    public class BoxScoreTeams
    {
        [JsonProperty("away")]
        public BoxScoreTeam Away { get; set; }

        [JsonProperty("home")]
        public BoxScoreTeam Home { get; set; }
    }
}