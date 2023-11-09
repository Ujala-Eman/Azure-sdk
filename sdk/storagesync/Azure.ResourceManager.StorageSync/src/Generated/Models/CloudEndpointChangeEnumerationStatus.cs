// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Cloud endpoint change enumeration status object. </summary>
    public partial class CloudEndpointChangeEnumerationStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudEndpointChangeEnumerationStatus"/>. </summary>
        internal CloudEndpointChangeEnumerationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudEndpointChangeEnumerationStatus"/>. </summary>
        /// <param name="lastUpdatedOn"> Last updated timestamp. </param>
        /// <param name="lastEnumerationStatus"> Status of last completed change enumeration. </param>
        /// <param name="activity"> Change enumeration activity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudEndpointChangeEnumerationStatus(DateTimeOffset? lastUpdatedOn, CloudEndpointLastChangeEnumerationStatus lastEnumerationStatus, CloudEndpointChangeEnumerationActivity activity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastUpdatedOn = lastUpdatedOn;
            LastEnumerationStatus = lastEnumerationStatus;
            Activity = activity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Last updated timestamp. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> Status of last completed change enumeration. </summary>
        public CloudEndpointLastChangeEnumerationStatus LastEnumerationStatus { get; }
        /// <summary> Change enumeration activity. </summary>
        public CloudEndpointChangeEnumerationActivity Activity { get; }
    }
}
