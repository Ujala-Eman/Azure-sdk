// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Resource Access Rule. </summary>
    public partial class ResourceAccessRule
    {
        /// <summary> Initializes a new instance of ResourceAccessRule. </summary>
        public ResourceAccessRule()
        {
        }

        /// <summary> Initializes a new instance of ResourceAccessRule. </summary>
        /// <param name="tenantId"> Tenant Id. </param>
        /// <param name="resourceId"> Resource Id. </param>
        internal ResourceAccessRule(string tenantId, string resourceId)
        {
            TenantId = tenantId;
            ResourceId = resourceId;
        }

        /// <summary> Tenant Id. </summary>
        public string TenantId { get; set; }
        /// <summary> Resource Id. </summary>
        public string ResourceId { get; set; }
    }
}
