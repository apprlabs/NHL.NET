using System;
using System.Collections.Generic;

namespace NHLDotNet.Exception
{
    /// <summary>
    /// Represents an exception when communicating with the service
    /// </summary>
    public class RequestException : System.Exception
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