// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// The outter wrapper for a request for conferences
    /// </summary>
    public class ConferenceResponse
    {
        /// <summary>
        /// Gets or sets the NHL copyright string
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
        
        /// <summary>
        /// Gets or sets the list of conferences
        /// </summary>
        [JsonProperty("conferences")]
        public List<Conference> Conferences { get; set; }
    }
}