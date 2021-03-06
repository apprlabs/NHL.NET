// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a contributor to an article
    /// </summary>
    public class Contributor
    {
        [JsonProperty("contributors")]
        public List<Author> Authors { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}