// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Resource Access Rule. </summary>
    public partial class StorageAccountResourceAccessRule
    {
        /// <summary> Initializes a new instance of <see cref="StorageAccountResourceAccessRule"/>. </summary>
        public StorageAccountResourceAccessRule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountResourceAccessRule"/>. </summary>
        /// <param name="tenantId"> Tenant Id. </param>
        /// <param name="resourceId"> Resource Id. </param>
        internal StorageAccountResourceAccessRule(Guid? tenantId, ResourceIdentifier resourceId)
        {
            TenantId = tenantId;
            ResourceId = resourceId;
        }

        /// <summary> Tenant Id. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Resource Id. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
