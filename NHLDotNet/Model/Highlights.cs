// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents highlights from game content
    /// </summary>
    public class Highlights
    {
        [JsonProperty("scoreboard")]
        public HighlightGroup Scoreboard { get; set; }
        
        [JsonProperty("gameCenter")]
        public HighlightGroup GameCenter { get; set; }
    }
}