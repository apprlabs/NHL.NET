// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents a conference
    /// </summary>
    public class Conference
    {
        /// <summary>
        /// Gets or sets the Id of this conference
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of this conference
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the link to this conference
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the abbreviation of this conference
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or sets the short name of this conference
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets whether this conference is active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}