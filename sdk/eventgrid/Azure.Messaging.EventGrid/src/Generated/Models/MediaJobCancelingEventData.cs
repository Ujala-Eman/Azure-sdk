// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Job canceling event data. </summary>
    internal partial class MediaJobCancelingEventData : MediaJobStateChangeEventData
    {
        /// <summary> Initializes a new instance of MediaJobCancelingEventData. </summary>
        internal MediaJobCancelingEventData()
        {
        }

        /// <summary> Initializes a new instance of MediaJobCancelingEventData. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="state"> The new state of the Job. </param>
        /// <param name="correlationData"> Gets the Job correlation data. </param>
        internal MediaJobCancelingEventData(MediaJobState? previousState, MediaJobState? state, IReadOnlyDictionary<string, string> correlationData) : base(previousState, state, correlationData)
        {
        }
    }
}
