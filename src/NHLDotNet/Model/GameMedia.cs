// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents media from a game
    /// </summary>
    public class GameMedia
    {
        // [JsonProperty("epg")]
        // public List<GameMediaEPG> ElectronicProgramGuide { get; set; }

        [JsonProperty("milestones")]
        public GameMediaMilestones Milestones { get; set; }
    }
}