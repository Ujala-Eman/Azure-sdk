// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The response payload of the create call operation. </summary>
    public partial class CreateCallResponse
    {
        /// <summary> Initializes a new instance of CreateCallResponse. </summary>
        internal CreateCallResponse()
        {
        }

        /// <summary> Initializes a new instance of CreateCallResponse. </summary>
        /// <param name="callLegId"> Call leg id of the call. </param>
        internal CreateCallResponse(string callLegId)
        {
            CallLegId = callLegId;
        }

        /// <summary> Call leg id of the call. </summary>
        public string CallLegId { get; }
    }
}
