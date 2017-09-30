// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents media milestones from a game
    /// </summary>
    public class Milestone
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timeAbsolute")]
        public DateTime TimeAbsolute { get; set; }
        
        [JsonProperty("timeOffset")]
        public int TimeOffset { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("statsEventId")]
        public int StatsEventId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("playerId")]
        public int PlayerId { get; set; }

        [JsonProperty("periodTime")]
        public string PeriodTime { get; set; }

        [JsonProperty("ordinalNum")]
        public string OrdinalNum { get; set; }

        [JsonProperty("highlight")]
        public ArticleMedia Highlight { get; set; }
    }
}