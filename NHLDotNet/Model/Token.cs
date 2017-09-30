// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a token
    /// </summary>
    public class Token
    {
        [JsonProperty("tokenGUID")]
        public string TokenGUID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videoId")]
        public string VideoID { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("bigBlurb")]
        public string BigBlurb { get; set; }

        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("mediaUrls")]
        public Dictionary<string, string> MediaURLs { get; set; }
    }
}