// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> The response from the List Storage SKUs operation. </summary>
    public partial class StorageSkuListResult
    {
        /// <summary> Initializes a new instance of StorageSkuListResult. </summary>
        internal StorageSkuListResult()
        {
        }

        /// <summary> Initializes a new instance of StorageSkuListResult. </summary>
        /// <param name="value"> Get the list result of storage SKUs and their properties. </param>
        internal StorageSkuListResult(IList<SkuInformation> value)
        {
            Value = value;
        }

        /// <summary> Get the list result of storage SKUs and their properties. </summary>
        public IList<SkuInformation> Value { get; internal set; }
    }
}
