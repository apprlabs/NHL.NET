// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;

namespace NHLDotNet.Request
{
    /// <summary>
    /// Represents an option that can be expanded on the "schedule" request
    /// </summary>
    public class ExpandOption
    {
        /// <summary>
        /// Gets or sets the internal value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Constructor (internal-only)
        /// </summary>
        /// <param name="option">The string to store as the value</param>
        private ExpandOption(string option)
        {
            Value = option;
        }

        /// <summary>
        /// Get an instance to expand teams in the schedule response
        /// </summary>
        public static ExpandOption Teams { 
            get { return new ExpandOption("schedule.teams"); } 
        }

        /// <summary>
        /// Get an instance to expand broadcasts in the schedule response
        /// </summary>
        public static ExpandOption Broadcasts { 
            get { return new ExpandOption("schedule.broadcasts"); } 
        }

        /// <summary>
        /// Get an instance to expand the linescore in the schedule response
        /// </summary>
        public static ExpandOption Linescore { 
            get { return new ExpandOption("schedule.linescore"); } 
        }

        /// <summary>
        /// Get an instance to expand tickets in the schedule response
        /// </summary>
        public static ExpandOption Tickets { 
            get { return new ExpandOption("schedule.ticket"); } 
        }

        /// <summary>
        /// Get an instance to expand media in the schedule response
        /// </summary>
        public static ExpandOption MediaGuide { 
            get { return new ExpandOption("schedule.game.content.media.epg"); } 
        }
    }
}