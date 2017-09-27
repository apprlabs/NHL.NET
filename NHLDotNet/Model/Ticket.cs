using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Ticket
    {
        [JsonProperty("ticketType")]
        public string TicketType { get; set; }

        [JsonProperty("ticketLink")]
        public string TicketLink { get; set; }
    }
}