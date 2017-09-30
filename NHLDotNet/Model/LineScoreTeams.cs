// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class LineScoreTeams
    {
        [JsonProperty("away")]
        public LineScoreTeam Away { get; set; }

        [JsonProperty("home")]
        public LineScoreTeam Home { get; set; }
    }
}