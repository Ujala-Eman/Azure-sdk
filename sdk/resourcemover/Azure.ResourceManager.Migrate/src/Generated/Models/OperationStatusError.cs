// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Class for operation status errors. </summary>
    public partial class OperationStatusError
    {
        /// <summary> Initializes a new instance of OperationStatusError. </summary>
        internal OperationStatusError()
        {
            Details = new ChangeTrackingList<OperationStatusError>();
            AdditionalInfo = new ChangeTrackingList<OperationErrorAdditionalInfo>();
        }

        /// <summary> Initializes a new instance of OperationStatusError. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="details"> The error details. </param>
        /// <param name="additionalInfo"> The additional info. </param>
        internal OperationStatusError(string code, string message, IReadOnlyList<OperationStatusError> details, IReadOnlyList<OperationErrorAdditionalInfo> additionalInfo)
        {
            Code = code;
            Message = message;
            Details = details;
            AdditionalInfo = additionalInfo;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The error details. </summary>
        public IReadOnlyList<OperationStatusError> Details { get; }
        /// <summary> The additional info. </summary>
        public IReadOnlyList<OperationErrorAdditionalInfo> AdditionalInfo { get; }
    }
}
