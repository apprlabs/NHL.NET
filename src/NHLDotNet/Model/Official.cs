// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the official for a game
    /// </summary>
    public class Official
    {
        [JsonProperty("official")]
        public OfficialDetails Details { get; set; }

        [JsonProperty("officialType")]
        public string Type { get; set; }
    }
}