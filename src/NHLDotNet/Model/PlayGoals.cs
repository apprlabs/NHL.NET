// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents goals for a play
    /// </summary>
    public class PlayGoals
    {
        [JsonProperty("away")]
        public int Away { get; set; }

        [JsonProperty("home")]
        public int Home { get; set; }
    }
}