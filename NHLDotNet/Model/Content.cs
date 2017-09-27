using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Content
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}