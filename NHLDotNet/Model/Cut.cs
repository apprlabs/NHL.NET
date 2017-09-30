// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents an image cut
    /// </summary>
    public class Cut
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }
        
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }
}