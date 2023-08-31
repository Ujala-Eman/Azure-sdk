// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the HciCluster data model.
    /// Cluster details.
    /// </summary>
    public partial class HciClusterData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HciClusterData"/>. </summary>
        /// <param name="location"> The location. </param>
        public HciClusterData(AzureLocation location) : base(location)
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="status"> Status of the cluster agent. </param>
        /// <param name="cloudId"> Unique, immutable resource id. </param>
        /// <param name="cloudManagementEndpoint"> Endpoint configured for management from the Azure portal. </param>
        /// <param name="aadClientId"> App id of cluster AAD identity. </param>
        /// <param name="aadTenantId"> Tenant id of cluster AAD identity. </param>
        /// <param name="aadApplicationObjectId"> Object id of cluster AAD identity. </param>
        /// <param name="aadServicePrincipalObjectId"> Id of cluster identity service principal. </param>
        /// <param name="softwareAssuranceProperties"> Software Assurance properties of the cluster. </param>
        /// <param name="desiredProperties"> Desired properties of the cluster. </param>
        /// <param name="reportedProperties"> Properties reported by cluster agent. </param>
        /// <param name="trialDaysRemaining"> Number of days remaining in the trial period. </param>
        /// <param name="billingModel"> Type of billing applied to the resource. </param>
        /// <param name="registrationTimestamp"> First cluster sync timestamp. </param>
        /// <param name="lastSyncTimestamp"> Most recent cluster sync timestamp. </param>
        /// <param name="lastBillingTimestamp"> Most recent billing meter timestamp. </param>
        /// <param name="serviceEndpoint"> Region specific DataPath Endpoint of the cluster. </param>
        /// <param name="resourceProviderObjectId"> Object id of RP Service Principal. </param>
        /// <param name="principalId"> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="typeIdentityType"> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </param>
        /// <param name="userAssignedIdentities"> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HciClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HciProvisioningState? provisioningState, HciClusterStatus? status, Guid? cloudId, string cloudManagementEndpoint, Guid? aadClientId, Guid? aadTenantId, Guid? aadApplicationObjectId, Guid? aadServicePrincipalObjectId, SoftwareAssuranceProperties softwareAssuranceProperties, HciClusterDesiredProperties desiredProperties, HciClusterReportedProperties reportedProperties, float? trialDaysRemaining, string billingModel, DateTimeOffset? registrationTimestamp, DateTimeOffset? lastSyncTimestamp, DateTimeOffset? lastBillingTimestamp, string serviceEndpoint, string resourceProviderObjectId, Guid? principalId, Guid? tenantId, HciManagedServiceIdentityType? typeIdentityType, IDictionary<string, UserAssignedIdentity> userAssignedIdentities, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            Status = status;
            CloudId = cloudId;
            CloudManagementEndpoint = cloudManagementEndpoint;
            AadClientId = aadClientId;
            AadTenantId = aadTenantId;
            AadApplicationObjectId = aadApplicationObjectId;
            AadServicePrincipalObjectId = aadServicePrincipalObjectId;
            SoftwareAssuranceProperties = softwareAssuranceProperties;
            DesiredProperties = desiredProperties;
            ReportedProperties = reportedProperties;
            TrialDaysRemaining = trialDaysRemaining;
            BillingModel = billingModel;
            RegistrationTimestamp = registrationTimestamp;
            LastSyncTimestamp = lastSyncTimestamp;
            LastBillingTimestamp = lastBillingTimestamp;
            ServiceEndpoint = serviceEndpoint;
            ResourceProviderObjectId = resourceProviderObjectId;
            PrincipalId = principalId;
            TenantId = tenantId;
            TypeIdentityType = typeIdentityType;
            UserAssignedIdentities = userAssignedIdentities;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterData"/> for deserialization. </summary>
        internal HciClusterData()
        {
        }

        /// <summary> Provisioning state. </summary>
        public HciProvisioningState? ProvisioningState { get; }
        /// <summary> Status of the cluster agent. </summary>
        public HciClusterStatus? Status { get; }
        /// <summary> Unique, immutable resource id. </summary>
        public Guid? CloudId { get; }
        /// <summary> Endpoint configured for management from the Azure portal. </summary>
        public string CloudManagementEndpoint { get; set; }
        /// <summary> App id of cluster AAD identity. </summary>
        public Guid? AadClientId { get; set; }
        /// <summary> Tenant id of cluster AAD identity. </summary>
        public Guid? AadTenantId { get; set; }
        /// <summary> Object id of cluster AAD identity. </summary>
        public Guid? AadApplicationObjectId { get; set; }
        /// <summary> Id of cluster identity service principal. </summary>
        public Guid? AadServicePrincipalObjectId { get; set; }
        /// <summary> Software Assurance properties of the cluster. </summary>
        public SoftwareAssuranceProperties SoftwareAssuranceProperties { get; set; }
        /// <summary> Desired properties of the cluster. </summary>
        public HciClusterDesiredProperties DesiredProperties { get; set; }
        /// <summary> Properties reported by cluster agent. </summary>
        public HciClusterReportedProperties ReportedProperties { get; }
        /// <summary> Number of days remaining in the trial period. </summary>
        public float? TrialDaysRemaining { get; }
        /// <summary> Type of billing applied to the resource. </summary>
        public string BillingModel { get; }
        /// <summary> First cluster sync timestamp. </summary>
        public DateTimeOffset? RegistrationTimestamp { get; }
        /// <summary> Most recent cluster sync timestamp. </summary>
        public DateTimeOffset? LastSyncTimestamp { get; }
        /// <summary> Most recent billing meter timestamp. </summary>
        public DateTimeOffset? LastBillingTimestamp { get; }
        /// <summary> Region specific DataPath Endpoint of the cluster. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Object id of RP Service Principal. </summary>
        public string ResourceProviderObjectId { get; }
        /// <summary> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? TenantId { get; }
        /// <summary> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </summary>
        public HciManagedServiceIdentityType? TypeIdentityType { get; set; }
        /// <summary> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
