// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the teams for game data
    /// </summary>
    public class GameDataTeams
    {
        [JsonProperty("away")]
        public Team Away { get; set; }

        [JsonProperty("home")]
        public Team Home { get; set; }
    }
}