using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// The outter wrapper for a request for conferences
    /// </summary>
    public class ConferenceResponse
    {
        /// <summary>
        /// Gets or sets the NHL copyright string
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
        
        /// <summary>
        /// Gets or sets the list of conferences
        /// </summary>
        [JsonProperty("conferences")]
        public List<Conference> Conferences { get; set; }
    }
}