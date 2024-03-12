// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady). </summary>
    public partial class BatchResizeOperationStatus
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

        /// <summary> Initializes a new instance of <see cref="BatchResizeOperationStatus"/>. </summary>
        internal BatchResizeOperationStatus()
        {
            Errors = new ChangeTrackingList<ResponseError>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchResizeOperationStatus"/>. </summary>
        /// <param name="targetDedicatedNodes"> The desired number of dedicated compute nodes in the pool. </param>
        /// <param name="targetLowPriorityNodes"> The desired number of Spot/low-priority compute nodes in the pool. </param>
        /// <param name="resizeTimeout"> The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="nodeDeallocationOption"> The default value is requeue. </param>
        /// <param name="startOn"> The time when this resize operation was started. </param>
        /// <param name="errors"> This property is set only if an error occurred during the last pool resize, and only when the pool allocationState is Steady. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchResizeOperationStatus(int? targetDedicatedNodes, int? targetLowPriorityNodes, TimeSpan? resizeTimeout, BatchNodeDeallocationOption? nodeDeallocationOption, DateTimeOffset? startOn, IReadOnlyList<ResponseError> errors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            ResizeTimeout = resizeTimeout;
            NodeDeallocationOption = nodeDeallocationOption;
            StartOn = startOn;
            Errors = errors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The desired number of dedicated compute nodes in the pool. </summary>
        public int? TargetDedicatedNodes { get; }
        /// <summary> The desired number of Spot/low-priority compute nodes in the pool. </summary>
        public int? TargetLowPriorityNodes { get; }
        /// <summary> The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public TimeSpan? ResizeTimeout { get; }
        /// <summary> The default value is requeue. </summary>
        public BatchNodeDeallocationOption? NodeDeallocationOption { get; }
        /// <summary> The time when this resize operation was started. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> This property is set only if an error occurred during the last pool resize, and only when the pool allocationState is Steady. </summary>
        public IReadOnlyList<ResponseError> Errors { get; }
    }
}
