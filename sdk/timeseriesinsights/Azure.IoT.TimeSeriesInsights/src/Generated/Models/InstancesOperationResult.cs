// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Result of a batch operation on a particular time series instance. Instance object is set when operation is successful (except put operation) and error object is set when operation is unsuccessful. </summary>
    public partial class InstancesOperationResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InstancesOperationResult"/>. </summary>
        internal InstancesOperationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InstancesOperationResult"/>. </summary>
        /// <param name="instance"> Time series instance object - set when the operation is successful (except put operation). </param>
        /// <param name="error"> Error object - set when the operation is unsuccessful. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InstancesOperationResult(TimeSeriesInstance instance, TimeSeriesOperationError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Instance = instance;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Time series instance object - set when the operation is successful (except put operation). </summary>
        public TimeSeriesInstance Instance { get; }
        /// <summary> Error object - set when the operation is unsuccessful. </summary>
        public TimeSeriesOperationError Error { get; }
    }
}
