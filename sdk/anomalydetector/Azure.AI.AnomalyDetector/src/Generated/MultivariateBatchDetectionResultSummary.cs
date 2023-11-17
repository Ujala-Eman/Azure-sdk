// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Multivariate anomaly detection status. </summary>
    public partial class MultivariateBatchDetectionResultSummary
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

        /// <summary> Initializes a new instance of <see cref="MultivariateBatchDetectionResultSummary"/>. </summary>
        /// <param name="status"> Status of detection results. </param>
        /// <param name="setupInfo">
        /// Detection request for batch inference. This is an asynchronous inference that
        /// will need another API to get detection results.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="setupInfo"/> is null. </exception>
        internal MultivariateBatchDetectionResultSummary(MultivariateBatchDetectionStatus status, MultivariateBatchDetectionOptions setupInfo)
        {
            Argument.AssertNotNull(setupInfo, nameof(setupInfo));

            Status = status;
            Errors = new ChangeTrackingList<ErrorResponse>();
            VariableStates = new ChangeTrackingList<VariableState>();
            SetupInfo = setupInfo;
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="MultivariateBatchDetectionResultSummary"/>. </summary>
        /// <param name="status"> Status of detection results. </param>
        /// <param name="errors"> Error message when detection fails. </param>
        /// <param name="variableStates"> Variable status. </param>
        /// <param name="setupInfo">
        /// Detection request for batch inference. This is an asynchronous inference that
        /// will need another API to get detection results.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MultivariateBatchDetectionResultSummary(MultivariateBatchDetectionStatus status, IReadOnlyList<ErrorResponse> errors, IReadOnlyList<VariableState> variableStates, MultivariateBatchDetectionOptions setupInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Errors = errors;
            VariableStates = variableStates;
            SetupInfo = setupInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MultivariateBatchDetectionResultSummary"/> for deserialization. </summary>
        internal MultivariateBatchDetectionResultSummary()
        {
        }

        /// <summary> Status of detection results. </summary>
        public MultivariateBatchDetectionStatus Status { get; }
        /// <summary> Error message when detection fails. </summary>
        public IReadOnlyList<ErrorResponse> Errors { get; }
        /// <summary> Variable status. </summary>
        public IReadOnlyList<VariableState> VariableStates { get; }
        /// <summary>
        /// Detection request for batch inference. This is an asynchronous inference that
        /// will need another API to get detection results.
        /// </summary>
        public MultivariateBatchDetectionOptions SetupInfo { get; }
    }
}
