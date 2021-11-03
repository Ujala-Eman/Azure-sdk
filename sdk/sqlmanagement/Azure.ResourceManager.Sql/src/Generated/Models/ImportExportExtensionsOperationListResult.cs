// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace SqlManagementClient.Models
{
    /// <summary> Import export operation extensions list. </summary>
    internal partial class ImportExportExtensionsOperationListResult
    {
        /// <summary> Initializes a new instance of ImportExportExtensionsOperationListResult. </summary>
        internal ImportExportExtensionsOperationListResult()
        {
            Value = new ChangeTrackingList<ImportExportExtensionsOperationResult>();
        }

        /// <summary> Initializes a new instance of ImportExportExtensionsOperationListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ImportExportExtensionsOperationListResult(IReadOnlyList<ImportExportExtensionsOperationResult> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ImportExportExtensionsOperationResult> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
