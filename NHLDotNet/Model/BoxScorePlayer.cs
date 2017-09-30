// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents player in a box score
    /// </summary>
    public class BoxScorePlayer
    {
        [JsonProperty("person")]
        public Player Player { get; set; }

        [JsonProperty("jerseyNumber")]
        public int JerseyNumber { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("stats")]
        public BoxScorePlayerStats Stats { get; set; }
    }
}