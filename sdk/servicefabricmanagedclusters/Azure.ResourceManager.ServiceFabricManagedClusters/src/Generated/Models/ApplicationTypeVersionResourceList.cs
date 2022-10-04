// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceFabricManagedClusters;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The list of application type version resources for the specified application type name resource. </summary>
    internal partial class ApplicationTypeVersionResourceList
    {
        /// <summary> Initializes a new instance of ApplicationTypeVersionResourceList. </summary>
        internal ApplicationTypeVersionResourceList()
        {
            Value = new ChangeTrackingList<ServiceFabricManagedApplicationTypeVersionData>();
        }

        /// <summary> Initializes a new instance of ApplicationTypeVersionResourceList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of application type version list results if there are any. </param>
        internal ApplicationTypeVersionResourceList(IReadOnlyList<ServiceFabricManagedApplicationTypeVersionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ServiceFabricManagedApplicationTypeVersionData> Value { get; }
        /// <summary> URL to get the next set of application type version list results if there are any. </summary>
        public string NextLink { get; }
    }
}
