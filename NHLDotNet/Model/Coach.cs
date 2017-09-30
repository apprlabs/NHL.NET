// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a coach
    /// </summary>
    public class Coach
    {
        [JsonProperty("person")]
        public Player Detail { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }
    }
}