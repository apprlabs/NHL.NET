// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class TeamResponse
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
        
        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }
    }
}