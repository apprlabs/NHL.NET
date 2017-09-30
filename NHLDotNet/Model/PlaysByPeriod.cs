// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents groups of plays in game feed for a period
    /// </summary>
    public class PlaysByPeriod
    {
        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("plays")]
        public int[] Plays { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }
}