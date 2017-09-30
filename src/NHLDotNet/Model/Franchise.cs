// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a franchise
    /// </summary>
    public class Franchise
    {
        [JsonProperty("franchiseId")]
        public int FranchiseId { get; set; }

        [JsonProperty("firstSeasonId")]
        public int FirstSeasonId { get; set; }

        [JsonProperty("mostRecentTeamId")]
        public int MostRecentTeamId { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }
        
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}