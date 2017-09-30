// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Teams
    {
        [JsonProperty("away")]
        public GameTeam Away { get; set; }

        [JsonProperty("home")]
        public GameTeam Home { get; set; }
    }
}