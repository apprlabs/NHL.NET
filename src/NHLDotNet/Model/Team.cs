// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a team
    /// </summary>
    public class Team
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("venue")]
        public Venue Venue { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("firstYearOfPlay")]
        public string firstYearOfPlay { get; set; }

        [JsonProperty("division")]
        public Division Division { get; set; }

        [JsonProperty("conference")]
        public Conference Conference { get; set; }

        [JsonProperty("franchise")]
        public Franchise Franchise { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("officialSiteUrl")]
        public string OfficialSiteURL { get; set; }

        [JsonProperty("franchiseId")]
        public int FranchiseId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}