// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> An error response from the Storage service. </summary>
    public partial class CloudError
    {
        /// <summary> Initializes a new instance of CloudError. </summary>
        internal CloudError()
        {
        }

        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="error"> An error response from the Storage service. </param>
        internal CloudError(CloudErrorBody error)
        {
            Error = error;
        }

        /// <summary> An error response from the Storage service. </summary>
        public CloudErrorBody Error { get; internal set; }
    }
}
