// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers
{
    /// <summary>
    /// A class representing the HDInsightClusterPool data model.
    /// Cluster pool.
    /// </summary>
    public partial class HDInsightClusterPoolData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPoolData"/>. </summary>
        /// <param name="location"> The location. </param>
        public HDInsightClusterPoolData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="deploymentId"> A unique id generated by the RP to identify the resource. </param>
        /// <param name="managedResourceGroupName"> A resource group created by RP, to hold the resources created by RP on-behalf of customers. It will also be used to generate aksManagedResourceGroupName by pattern: MC_{managedResourceGroupName}_{clusterPoolName}_{region}. Please make sure it meets resource group name restriction. </param>
        /// <param name="aksManagedResourceGroupName"> A resource group created by AKS, to hold the infrastructure resources created by AKS on-behalf of customers. It is generated by cluster pool name and managed resource group name by pattern: MC_{managedResourceGroupName}_{clusterPoolName}_{region}. </param>
        /// <param name="clusterPoolProfile"> CLuster pool profile. </param>
        /// <param name="computeProfile"> CLuster pool compute profile. </param>
        /// <param name="aksClusterProfile"> Properties of underlying AKS cluster. </param>
        /// <param name="networkProfile"> Cluster pool network profile. </param>
        /// <param name="logAnalyticsProfile"> Cluster pool log analytics profile to enable OMS agent for AKS cluster. </param>
        /// <param name="status"> Business status of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HDInsightProvisioningStatus? provisioningState, string deploymentId, string managedResourceGroupName, string aksManagedResourceGroupName, ClusterPoolProfile clusterPoolProfile, ClusterPoolComputeProfile computeProfile, AksClusterProfile aksClusterProfile, ClusterPoolNetworkProfile networkProfile, ClusterPoolLogAnalyticsProfile logAnalyticsProfile, string status, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            DeploymentId = deploymentId;
            ManagedResourceGroupName = managedResourceGroupName;
            AksManagedResourceGroupName = aksManagedResourceGroupName;
            ClusterPoolProfile = clusterPoolProfile;
            ComputeProfile = computeProfile;
            AksClusterProfile = aksClusterProfile;
            NetworkProfile = networkProfile;
            LogAnalyticsProfile = logAnalyticsProfile;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPoolData"/> for deserialization. </summary>
        internal HDInsightClusterPoolData()
        {
        }

        /// <summary> Provisioning state of the resource. </summary>
        public HDInsightProvisioningStatus? ProvisioningState { get; }
        /// <summary> A unique id generated by the RP to identify the resource. </summary>
        public string DeploymentId { get; }
        /// <summary> A resource group created by RP, to hold the resources created by RP on-behalf of customers. It will also be used to generate aksManagedResourceGroupName by pattern: MC_{managedResourceGroupName}_{clusterPoolName}_{region}. Please make sure it meets resource group name restriction. </summary>
        public string ManagedResourceGroupName { get; set; }
        /// <summary> A resource group created by AKS, to hold the infrastructure resources created by AKS on-behalf of customers. It is generated by cluster pool name and managed resource group name by pattern: MC_{managedResourceGroupName}_{clusterPoolName}_{region}. </summary>
        public string AksManagedResourceGroupName { get; }
        /// <summary> CLuster pool profile. </summary>
        internal ClusterPoolProfile ClusterPoolProfile { get; set; }
        /// <summary> Cluster pool version is a 2-part version. </summary>
        public string ClusterPoolVersion
        {
            get => ClusterPoolProfile is null ? default : ClusterPoolProfile.ClusterPoolVersion;
            set => ClusterPoolProfile = new ClusterPoolProfile(value);
        }

        /// <summary> CLuster pool compute profile. </summary>
        public ClusterPoolComputeProfile ComputeProfile { get; set; }
        /// <summary> Properties of underlying AKS cluster. </summary>
        public AksClusterProfile AksClusterProfile { get; }
        /// <summary> Cluster pool network profile. </summary>
        internal ClusterPoolNetworkProfile NetworkProfile { get; set; }
        /// <summary> Cluster pool subnet resource id. </summary>
        public ResourceIdentifier NetworkSubnetId
        {
            get => NetworkProfile is null ? default : NetworkProfile.SubnetId;
            set => NetworkProfile = new ClusterPoolNetworkProfile(value);
        }

        /// <summary> Cluster pool log analytics profile to enable OMS agent for AKS cluster. </summary>
        public ClusterPoolLogAnalyticsProfile LogAnalyticsProfile { get; set; }
        /// <summary> Business status of the resource. </summary>
        public string Status { get; }
    }
}
