// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a team in a game
    /// </summary>
    public class GameTeam
    {
        [JsonProperty("leagueRecord")]
        public LeagueRecord LeageRecord { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }
    }
}