// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Status
    {
        [JsonProperty("abstractGameState")]
        public string AbstractGameState { get; set; }

        [JsonProperty("codedGameState")]
        public string CodedGameState { get; set; }

        [JsonProperty("detailedState")]
        public string DetailedState { get; set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("startTimeTBD")]
        public bool StartTimeTBD { get; set; }
    }
}