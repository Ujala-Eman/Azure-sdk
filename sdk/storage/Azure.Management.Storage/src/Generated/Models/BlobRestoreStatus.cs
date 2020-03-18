// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> Blob restore status. </summary>
    public partial class BlobRestoreStatus
    {
        /// <summary> Initializes a new instance of BlobRestoreStatus. </summary>
        public BlobRestoreStatus()
        {
        }

        /// <summary> Initializes a new instance of BlobRestoreStatus. </summary>
        /// <param name="status"> The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed. </param>
        /// <param name="failureReason"> Failure reason when blob restore is failed. </param>
        /// <param name="restoreId"> Id for tracking blob restore request. </param>
        /// <param name="parameters"> Blob restore request parameters. </param>
        internal BlobRestoreStatus(BlobRestoreProgressStatus? status, string failureReason, string restoreId, BlobRestoreParameters parameters)
        {
            Status = status;
            FailureReason = failureReason;
            RestoreId = restoreId;
            Parameters = parameters;
        }

        /// <summary> The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed. </summary>
        public BlobRestoreProgressStatus? Status { get; internal set; }
        /// <summary> Failure reason when blob restore is failed. </summary>
        public string FailureReason { get; internal set; }
        /// <summary> Id for tracking blob restore request. </summary>
        public string RestoreId { get; internal set; }
        /// <summary> Blob restore request parameters. </summary>
        public BlobRestoreParameters Parameters { get; internal set; }
    }
}
