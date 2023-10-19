// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for transferring call to a participant. </summary>
    internal partial class TransferToParticipantRequestInternal
    {
        /// <summary> Initializes a new instance of TransferToParticipantRequestInternal. </summary>
        /// <param name="targetParticipant"> The identity of the target where call should be transferred to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetParticipant"/> is null. </exception>
        public TransferToParticipantRequestInternal(CommunicationIdentifierModel targetParticipant)
        {
            Argument.AssertNotNull(targetParticipant, nameof(targetParticipant));

            TargetParticipant = targetParticipant;
        }

        /// <summary> The identity of the target where call should be transferred to. </summary>
        public CommunicationIdentifierModel TargetParticipant { get; }
        /// <summary> Used by customer to send custom context to targets. </summary>
        public CustomContextInternal CustomContext { get; set; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; set; }
        /// <summary> Transferee is the participant who is transferred away. </summary>
        public CommunicationIdentifierModel Transferee { get; set; }
        /// <summary>
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </summary>
        public string OperationCallbackUri { get; set; }
    }
}
