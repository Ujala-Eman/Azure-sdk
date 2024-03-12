// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The blob service properties for Last access time based tracking policy. </summary>
    public partial class LastAccessTimeTrackingPolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LastAccessTimeTrackingPolicy"/>. </summary>
        /// <param name="isEnabled"> When set to true last access time based tracking is enabled. </param>
        public LastAccessTimeTrackingPolicy(bool isEnabled)
        {
            IsEnabled = isEnabled;
            BlobType = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="LastAccessTimeTrackingPolicy"/>. </summary>
        /// <param name="isEnabled"> When set to true last access time based tracking is enabled. </param>
        /// <param name="name"> Name of the policy. The valid value is AccessTimeTracking. This field is currently read only. </param>
        /// <param name="trackingGranularityInDays"> The field specifies blob object tracking granularity in days, typically how often the blob object should be tracked.This field is currently read only with value as 1. </param>
        /// <param name="blobType"> An array of predefined supported blob types. Only blockBlob is the supported value. This field is currently read only. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LastAccessTimeTrackingPolicy(bool isEnabled, LastAccessTimeTrackingPolicyName? name, int? trackingGranularityInDays, IList<string> blobType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Name = name;
            TrackingGranularityInDays = trackingGranularityInDays;
            BlobType = blobType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LastAccessTimeTrackingPolicy"/> for deserialization. </summary>
        internal LastAccessTimeTrackingPolicy()
        {
        }

        /// <summary> When set to true last access time based tracking is enabled. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> Name of the policy. The valid value is AccessTimeTracking. This field is currently read only. </summary>
        public LastAccessTimeTrackingPolicyName? Name { get; set; }
        /// <summary> The field specifies blob object tracking granularity in days, typically how often the blob object should be tracked.This field is currently read only with value as 1. </summary>
        public int? TrackingGranularityInDays { get; set; }
        /// <summary> An array of predefined supported blob types. Only blockBlob is the supported value. This field is currently read only. </summary>
        public IList<string> BlobType { get; }
    }
}
