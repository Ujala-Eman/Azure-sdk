// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The TranscriptionStopped. </summary>
    public partial class TranscriptionStopped
    {
        /// <summary> Initializes a new instance of TranscriptionStopped. </summary>
        internal TranscriptionStopped()
        {
        }

        /// <summary> Initializes a new instance of TranscriptionStopped. </summary>
        /// <param name="transcriptionUpdateResult"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        internal TranscriptionStopped(TranscriptionUpdate transcriptionUpdateResult)
        {
            TranscriptionUpdateResult = transcriptionUpdateResult;
        }

        /// <summary> Defines the result for TranscriptionUpdate with the current status and the details about the status. </summary>
        public TranscriptionUpdate TranscriptionUpdateResult { get; }
    }
}
