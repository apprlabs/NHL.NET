// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a venue
    /// </summary>
    public class Venue
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("timeZone")]
        public TimeZone TimeZone { get; set; }
    }
}