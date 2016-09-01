// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The result of the request or operation.
    /// </summary>
    public partial class FileOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the FileOperationResult class.
        /// </summary>
        public FileOperationResult() { }

        /// <summary>
        /// Initializes a new instance of the FileOperationResult class.
        /// </summary>
        /// <param name="operationResult">the result of the operation or
        /// request.</param>
        public FileOperationResult(bool? operationResult = default(bool?))
        {
            OperationResult = operationResult;
        }

        /// <summary>
        /// Gets the result of the operation or request.
        /// </summary>
        [JsonProperty(PropertyName = "boolean")]
        public bool? OperationResult { get; private set; }

    }
}
