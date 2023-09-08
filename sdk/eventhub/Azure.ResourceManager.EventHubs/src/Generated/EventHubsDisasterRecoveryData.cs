// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing the EventHubsDisasterRecovery data model.
    /// Single item in List or Get Alias(Disaster Recovery configuration) operation
    /// </summary>
    public partial class EventHubsDisasterRecoveryData : ResourceData
    {
        /// <summary> Initializes a new instance of EventHubsDisasterRecoveryData. </summary>
        public EventHubsDisasterRecoveryData()
        {
        }

        /// <summary> Initializes a new instance of EventHubsDisasterRecoveryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the Alias(Disaster Recovery configuration) - possible values 'Accepted' or 'Succeeded' or 'Failed'. </param>
        /// <param name="partnerNamespace"> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </param>
        /// <param name="alternateName"> Alternate name specified when alias and namespace names are same. </param>
        /// <param name="role"> role of namespace in GEO DR - possible values 'Primary' or 'PrimaryNotReplicating' or 'Secondary'. </param>
        /// <param name="pendingReplicationOperationsCount"> Number of entities pending to be replicated. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal EventHubsDisasterRecoveryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EventHubsDisasterRecoveryProvisioningState? provisioningState, string partnerNamespace, string alternateName, EventHubsDisasterRecoveryRole? role, long? pendingReplicationOperationsCount, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PartnerNamespace = partnerNamespace;
            AlternateName = alternateName;
            Role = role;
            PendingReplicationOperationsCount = pendingReplicationOperationsCount;
            Location = location;
        }

        /// <summary> Provisioning state of the Alias(Disaster Recovery configuration) - possible values 'Accepted' or 'Succeeded' or 'Failed'. </summary>
        public EventHubsDisasterRecoveryProvisioningState? ProvisioningState { get; }
        /// <summary> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </summary>
        public string PartnerNamespace { get; set; }
        /// <summary> Alternate name specified when alias and namespace names are same. </summary>
        public string AlternateName { get; set; }
        /// <summary> role of namespace in GEO DR - possible values 'Primary' or 'PrimaryNotReplicating' or 'Secondary'. </summary>
        public EventHubsDisasterRecoveryRole? Role { get; }
        /// <summary> Number of entities pending to be replicated. </summary>
        public long? PendingReplicationOperationsCount { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
