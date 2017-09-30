// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// The outter wrapper for a request for players
    /// </summary>
    public class PlayerResponse
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("people")]
        public List<Player> Players { get; set; }
    }
}