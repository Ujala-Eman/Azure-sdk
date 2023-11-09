// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> An output event timestamp. </summary>
    public partial class LastOutputEventTimestamp
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LastOutputEventTimestamp"/>. </summary>
        internal LastOutputEventTimestamp()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LastOutputEventTimestamp"/>. </summary>
        /// <param name="lastOutputEventOn"> The last output event time. </param>
        /// <param name="lastUpdatedOn"> The time that the last update happened. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LastOutputEventTimestamp(DateTimeOffset? lastOutputEventOn, DateTimeOffset? lastUpdatedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastOutputEventOn = lastOutputEventOn;
            LastUpdatedOn = lastUpdatedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The last output event time. </summary>
        public DateTimeOffset? LastOutputEventOn { get; }
        /// <summary> The time that the last update happened. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
    }
}
