// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </summary>
    public partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of <see cref="ErrorResponse"/>. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ErrorResponse"/>. </summary>
        /// <param name="error"> The error object. </param>
        internal ErrorResponse(ResponseError error)
        {
            Error = error;
        }

        /// <summary> The error object. </summary>
        public ResponseError Error { get; }
    }
}
