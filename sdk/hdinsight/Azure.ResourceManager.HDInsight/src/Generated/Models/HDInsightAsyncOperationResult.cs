// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The azure async operation response. </summary>
    public partial class HDInsightAsyncOperationResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightAsyncOperationResult"/>. </summary>
        internal HDInsightAsyncOperationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightAsyncOperationResult"/>. </summary>
        /// <param name="status"> The async operation state. </param>
        /// <param name="error"> The operation error information. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightAsyncOperationResult(HDInsightAsyncOperationState? status, ResponseError error, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            Error = error;
            _rawData = rawData;
        }

        /// <summary> The async operation state. </summary>
        public HDInsightAsyncOperationState? Status { get; }
        /// <summary> The operation error information. </summary>
        public ResponseError Error { get; }
    }
}
