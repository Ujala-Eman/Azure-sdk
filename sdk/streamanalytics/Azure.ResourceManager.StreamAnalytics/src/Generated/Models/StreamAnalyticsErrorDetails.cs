// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Common error details representation. </summary>
    public partial class StreamAnalyticsErrorDetails
    {
        /// <summary> Initializes a new instance of StreamAnalyticsErrorDetails. </summary>
        internal StreamAnalyticsErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of StreamAnalyticsErrorDetails. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="target"> Error target. </param>
        /// <param name="message"> Error message. </param>
        internal StreamAnalyticsErrorDetails(string code, string target, string message)
        {
            Code = code;
            Target = target;
            Message = message;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error target. </summary>
        public string Target { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
    }
}
