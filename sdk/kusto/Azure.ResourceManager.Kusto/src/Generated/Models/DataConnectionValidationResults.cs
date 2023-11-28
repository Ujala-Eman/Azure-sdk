// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list Kusto data connection validation result. </summary>
    public partial class DataConnectionValidationResults
    {
        /// <summary> Initializes a new instance of <see cref="DataConnectionValidationResults"/>. </summary>
        internal DataConnectionValidationResults()
        {
            Value = new ChangeTrackingList<DataConnectionValidationResult>();
        }

        /// <summary> Initializes a new instance of <see cref="DataConnectionValidationResults"/>. </summary>
        /// <param name="value"> The list of Kusto data connection validation errors. </param>
        internal DataConnectionValidationResults(IReadOnlyList<DataConnectionValidationResult> value)
        {
            Value = value;
        }

        /// <summary> The list of Kusto data connection validation errors. </summary>
        public IReadOnlyList<DataConnectionValidationResult> Value { get; }
    }
}
