// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionRefreshStatus. </summary>
    public partial class LinkConnectionRefreshStatus
    {
        /// <summary> Initializes a new instance of <see cref="LinkConnectionRefreshStatus"/>. </summary>
        internal LinkConnectionRefreshStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkConnectionRefreshStatus"/>. </summary>
        /// <param name="refreshStatus"> Link connection refresh status. </param>
        /// <param name="errorMessage"> Link connection refresh error message. </param>
        internal LinkConnectionRefreshStatus(string refreshStatus, string errorMessage)
        {
            RefreshStatus = refreshStatus;
            ErrorMessage = errorMessage;
        }

        /// <summary> Link connection refresh status. </summary>
        public string RefreshStatus { get; }
        /// <summary> Link connection refresh error message. </summary>
        public string ErrorMessage { get; }
    }
}
