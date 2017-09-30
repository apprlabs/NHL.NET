// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the data from a game feed
    /// </summary>
    public class GameData
    {
        [JsonProperty("game")]
        public Game Game { get; set; }

        [JsonProperty("datetime")]
        public GameTimes GameTimes { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("players")]
        public Dictionary<string, Player> Players { get; set; }

        [JsonProperty("teams")]
        public GameDataTeams Teams { get; set; }

        [JsonProperty("venue")]
        public Venue Venue { get; set; }
    }
}