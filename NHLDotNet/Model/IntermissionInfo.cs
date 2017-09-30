// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class IntermissionInfo
    {
        [JsonProperty("intermissionTimeRemaining")]
        public int IntermissionTimeRemaining { get; set; }

        [JsonProperty("intermissionTimeElapsed")]
        public int IntermissionTimeElapsed { get; set; }

        [JsonProperty("inIntermission")]
        public bool inIntermission { get; set; }
    }
}