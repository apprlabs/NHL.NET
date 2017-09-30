// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents an article
    /// </summary>
    public class Article
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("subhead")]
        public string Subhead { get; set; }

        [JsonProperty("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonProperty("seoDescription")]
        public string SeoDescription { get; set; }

        [JsonProperty("seoKeywords")]
        public string SeoKeywords { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("commenting")]
        public bool Commenting { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("tokenData")]
        public Dictionary<string, Token> Tokens { get; set; }

        [JsonProperty("contributor")]
        public Contributor Contributor { get; set; }

        [JsonProperty("keywordsDisplay")]
        public List<Keyword> KeywordsDisplay { get; set; }

        [JsonProperty("keywordsAll")]
        public List<Keyword> KeywordsAll { get; set; }

        [JsonProperty("approval")]
        public string Approval { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("dataURI")]
        public string DataURI { get; set; }

        [JsonProperty("primaryKeyword")]
        public Keyword PrimaryKeyword { get; set; }

        [JsonProperty("media")]
        public ArticleMedia Media { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }
    }
}