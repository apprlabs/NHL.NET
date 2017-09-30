// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the metadata for a request
    /// </summary>
    public class MetaData
    {
        [JsonProperty("wait")]
        public int Wait { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }
}