// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents decisions from the game
    /// </summary>
    public class Decisions
    {
        [JsonProperty("firstStar")]
        public GameStar FirstStar { get; set; }

        [JsonProperty("secondStar")]
        public GameStar SecondStar { get; set; }

        [JsonProperty("thirdStar")]
        public GameStar ThirdStar { get; set; }
    }
}