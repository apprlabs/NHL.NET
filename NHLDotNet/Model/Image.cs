// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents an image for an article
    /// </summary>
    public class Image
    {
        [JsonProperty("cuts")]
        public Dictionary<string, Cut> Cuts { get; set; }

        [JsonProperty("altText")]
        public string AltText { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}