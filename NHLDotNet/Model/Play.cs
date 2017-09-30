// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a play in game feed
    /// </summary>
    public class Play
    {
        [JsonProperty("result")]
        public PlayResult Result { get; set; }

        [JsonProperty("about")]
        public PlayDetails Details { get; set; }

        // [JsonProperty("coordinates")]
        // public PlayCoordinates Coordinates { get; set; }
    }
}