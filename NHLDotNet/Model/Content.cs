// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents game content
    /// </summary>
    public class Content
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
        
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("editorial")]
        public Editorial Editorials { get; set; }

        [JsonProperty("media")]
        public GameMedia Media { get; set; }

        [JsonProperty("highlights")]
        public Highlights Highlights { get; set; }
    }
}