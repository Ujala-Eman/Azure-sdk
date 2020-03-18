// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> Result of the request to list Storage operations. It contains a list of operations and a URL link to get the next set of results. </summary>
    public partial class OperationListResult
    {
        /// <summary> Initializes a new instance of OperationListResult. </summary>
        internal OperationListResult()
        {
        }

        /// <summary> Initializes a new instance of OperationListResult. </summary>
        /// <param name="value"> List of Storage operations supported by the Storage resource provider. </param>
        internal OperationListResult(IList<Operation> value)
        {
            Value = value;
        }

        /// <summary> List of Storage operations supported by the Storage resource provider. </summary>
        public IList<Operation> Value { get; internal set; }
    }
}
