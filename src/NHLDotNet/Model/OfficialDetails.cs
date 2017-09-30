// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the details for an official for a game
    /// </summary>
    public class OfficialDetails
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}