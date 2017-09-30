// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a highlight group from game content
    /// </summary>
    public class HighlightGroup
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("topicList")]
        public string TopicList { get; set; }
        
        [JsonProperty("items")]
        public ArticleMedia Items { get; set; }
    }
}