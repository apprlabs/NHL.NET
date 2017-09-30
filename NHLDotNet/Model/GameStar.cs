// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents stars from a game
    /// </summary>
    public class GameStar
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}