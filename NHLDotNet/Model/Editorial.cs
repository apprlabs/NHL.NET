// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the groups of articles
    /// </summary>
    public class Editorial
    {
        [JsonProperty("preview")]
        public Articles Preview { get; set; }

        [JsonProperty("articles")]
        public Articles Articles { get; set; }

        [JsonProperty("recap")]
        public Articles Recap { get; set; }
    }
}