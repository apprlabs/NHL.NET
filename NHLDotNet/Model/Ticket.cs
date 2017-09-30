// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

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