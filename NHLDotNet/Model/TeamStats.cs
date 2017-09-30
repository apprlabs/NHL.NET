// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents team stats from a box score
    /// </summary>
    public class TeamStats
    {
        [JsonProperty("teamSkaterStats")]
        public TeamSkaterStats TeamSkaterStats { get; set; }
    }
}