// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The settings to enable AAD authentication on the cluster. </summary>
    public partial class ManagedClusterAzureActiveDirectory
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAzureActiveDirectory"/>. </summary>
        public ManagedClusterAzureActiveDirectory()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAzureActiveDirectory"/>. </summary>
        /// <param name="tenantId"> Azure active directory tenant id. </param>
        /// <param name="clusterApplication"> Azure active directory cluster application id. </param>
        /// <param name="clientApplication"> Azure active directory client application id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterAzureActiveDirectory(Guid? tenantId, string clusterApplication, string clientApplication, Dictionary<string, BinaryData> rawData)
        {
            TenantId = tenantId;
            ClusterApplication = clusterApplication;
            ClientApplication = clientApplication;
            _rawData = rawData;
        }

        /// <summary> Azure active directory tenant id. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Azure active directory cluster application id. </summary>
        public string ClusterApplication { get; set; }
        /// <summary> Azure active directory client application id. </summary>
        public string ClientApplication { get; set; }
    }
}
