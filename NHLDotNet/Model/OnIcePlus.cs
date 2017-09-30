// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents extra detail for on ice for a box score
    /// </summary>
    public class OnIcePlus
    {
        [JsonProperty("playerId")]
        public int PlayerID { get; set; }

        [JsonProperty("shiftDuration")]
        public int ShiftDuration { get; set; }

        [JsonProperty("stamina")]
        public int Stamina { get; set; }
    }
}