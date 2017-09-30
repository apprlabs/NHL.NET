// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a team in shootout info
    /// </summary>
    public class ShootoutInfoTeam
    {
        [JsonProperty("scores")]
        public int Scores { get; set; }

        [JsonProperty("attempts")]
        public int Attempts { get; set; }
    }
}