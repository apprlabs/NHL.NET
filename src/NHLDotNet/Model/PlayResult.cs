// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a result from a play
    /// </summary>
    public class PlayResult
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("eventCode")]
        public string EventCode { get; set; }

        [JsonProperty("eventTypeId")]
        public string EventTypeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}