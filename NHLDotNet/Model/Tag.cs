// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a tag
    /// </summary>
    public class Tag
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("@value")]
        public string Value { get; set; }

        [JsonProperty("@displayName")]
        public string DisplayName { get; set; }
    }
}