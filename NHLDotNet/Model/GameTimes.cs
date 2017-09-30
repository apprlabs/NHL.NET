// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the start/end times for a game
    /// </summary>
    public class GameTimes
    {
        [JsonProperty("dateTime")]
        public DateTime StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public DateTime EndTime { get; set; }
    }
}