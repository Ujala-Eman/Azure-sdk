// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The play audio result event. </summary>
    public partial class PlayAudioResultEvent
    {
        /// <summary> Initializes a new instance of <see cref="PlayAudioResultEvent"/>. </summary>
        /// <param name="status"> The status of the operation. </param>
        internal PlayAudioResultEvent(OperationStatus status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="PlayAudioResultEvent"/>. </summary>
        /// <param name="resultInfo"> The result details. </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="status"> The status of the operation. </param>
        internal PlayAudioResultEvent(ResultInfo resultInfo, string operationContext, OperationStatus status)
        {
            ResultInfo = resultInfo;
            OperationContext = operationContext;
            Status = status;
        }

        /// <summary> The result details. </summary>
        public ResultInfo ResultInfo { get; }
        /// <summary> The operation context. </summary>
        public string OperationContext { get; }
        /// <summary> The status of the operation. </summary>
        public OperationStatus Status { get; }
    }
}
