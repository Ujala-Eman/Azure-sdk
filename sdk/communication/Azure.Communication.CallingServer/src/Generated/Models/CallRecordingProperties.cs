// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The response payload of get call recording properties operation. </summary>
    public partial class CallRecordingProperties
    {
        /// <summary> Initializes a new instance of <see cref="CallRecordingProperties"/>. </summary>
        /// <param name="recordingState"> The state of the recording. </param>
        internal CallRecordingProperties(CallRecordingState recordingState)
        {
            RecordingState = recordingState;
        }

        /// <summary> The state of the recording. </summary>
        public CallRecordingState RecordingState { get; }
    }
}
