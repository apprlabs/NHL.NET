// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Net.Http;

namespace NHLDotNet.Exception
{
    /// <summary>
    /// Represents an exception when communicating with the service
    /// </summary>
    public class RequestException : HttpRequestException
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RequestException()
        {
        }

        /// <summary>
        /// Constructor + message
        /// </summary>
        /// <param name="message">The exception message</param>
        public RequestException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor + message + inner exception
        /// </summary>
        /// <param name="message">The exception message</param>
        /// <param name="inner">The inner exception</param>
        public RequestException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}