// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The CallDisconnectedEvent. </summary>
    internal partial class CallDisconnectedEvent
    {
        /// <summary> Initializes a new instance of CallDisconnectedEvent. </summary>
        internal CallDisconnectedEvent()
        {
        }

        /// <summary> Gets the type. </summary>
        public AcsEventType? Type { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
    }
}
