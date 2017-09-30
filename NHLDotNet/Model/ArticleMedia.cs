// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents media for an article
    /// </summary>
    public class ArticleMedia
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("authFlow")]
        public bool AuthFlow { get; set; }

        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        [JsonProperty("mediaState")]
        public string MediaState { get; set; }

        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("playbacks")]
        public List<Playback> Playbacks { get; set; }
    }
}