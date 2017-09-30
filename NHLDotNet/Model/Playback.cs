// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents playback options for an article
    /// </summary>
    public class Playback
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }
    }
}