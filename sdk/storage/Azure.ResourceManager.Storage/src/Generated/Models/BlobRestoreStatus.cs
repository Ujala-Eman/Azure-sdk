// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Blob restore status. </summary>
    public partial class BlobRestoreStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobRestoreStatus"/>. </summary>
        internal BlobRestoreStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BlobRestoreStatus"/>. </summary>
        /// <param name="status"> The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed. </param>
        /// <param name="failureReason"> Failure reason when blob restore is failed. </param>
        /// <param name="restoreId"> Id for tracking blob restore request. </param>
        /// <param name="parameters"> Blob restore request parameters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobRestoreStatus(BlobRestoreProgressStatus? status, string failureReason, string restoreId, BlobRestoreContent parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            FailureReason = failureReason;
            RestoreId = restoreId;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed. </summary>
        public BlobRestoreProgressStatus? Status { get; }
        /// <summary> Failure reason when blob restore is failed. </summary>
        public string FailureReason { get; }
        /// <summary> Id for tracking blob restore request. </summary>
        public string RestoreId { get; }
        /// <summary> Blob restore request parameters. </summary>
        public BlobRestoreContent Parameters { get; }
    }
}
