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
    public class GameMediaMilestones
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("streamStart")]
        public DateTime StreamStart { get; set; }

        [JsonProperty("items")]
        public List<Milestone> Milestones { get; set; }
    }
}