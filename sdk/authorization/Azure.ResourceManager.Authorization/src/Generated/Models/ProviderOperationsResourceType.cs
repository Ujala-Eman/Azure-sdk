// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Resource Type. </summary>
    public partial class ProviderOperationsResourceType
    {
        /// <summary> Initializes a new instance of ProviderOperationsResourceType. </summary>
        internal ProviderOperationsResourceType()
        {
            Operations = new ChangeTrackingList<ProviderOperation>();
        }

        /// <summary> Initializes a new instance of ProviderOperationsResourceType. </summary>
        /// <param name="name"> The resource type name. </param>
        /// <param name="displayName"> The resource type display name. </param>
        /// <param name="operations"> The resource type operations. </param>
        internal ProviderOperationsResourceType(string name, string displayName, IReadOnlyList<ProviderOperation> operations)
        {
            Name = name;
            DisplayName = displayName;
            Operations = operations;
        }

        /// <summary> The resource type name. </summary>
        public string Name { get; }
        /// <summary> The resource type display name. </summary>
        public string DisplayName { get; }
        /// <summary> The resource type operations. </summary>
        public IReadOnlyList<ProviderOperation> Operations { get; }
    }
}
