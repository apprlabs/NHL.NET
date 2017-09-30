// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// The outter wrapper for a request for schedules
    /// </summary>
    public class ScheduleResponse
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
        
        [JsonProperty("totalEvents")]
        public int TotalEvents { get; set; }
        
        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }
        
        [JsonProperty("totalMatches")]
        public int TotalMatches { get; set; }
        
        [JsonProperty("wait")]
        public int Wait { get; set; }
        
        [JsonProperty("dates")]
        public List<Date> Dates { get; set; }
    }
}