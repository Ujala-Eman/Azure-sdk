// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The job error information containing the list of job errors. </summary>
    public partial class JobErrorDetails
    {
        /// <summary> Initializes a new instance of JobErrorDetails. </summary>
        internal JobErrorDetails()
        {
            ErrorDetails = new ChangeTrackingList<JobErrorItem>();
        }

        /// <summary> Initializes a new instance of JobErrorDetails. </summary>
        /// <param name="errorDetails"> The error details. </param>
        /// <param name="code"> The code intended for programmatic access. </param>
        /// <param name="message"> The message that describes the error in detail. </param>
        internal JobErrorDetails(IReadOnlyList<JobErrorItem> errorDetails, string code, string message)
        {
            ErrorDetails = errorDetails;
            Code = code;
            Message = message;
        }

        /// <summary> The error details. </summary>
        public IReadOnlyList<JobErrorItem> ErrorDetails { get; }
        /// <summary> The code intended for programmatic access. </summary>
        public string Code { get; }
        /// <summary> The message that describes the error in detail. </summary>
        public string Message { get; }
    }
}
