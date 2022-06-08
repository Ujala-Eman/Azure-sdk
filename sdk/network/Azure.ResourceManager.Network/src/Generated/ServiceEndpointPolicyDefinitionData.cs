// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ServiceEndpointPolicyDefinition data model. </summary>
    public partial class ServiceEndpointPolicyDefinitionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ServiceEndpointPolicyDefinitionData"/>. </summary>
        public ServiceEndpointPolicyDefinitionData()
        {
            ServiceResources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceEndpointPolicyDefinitionData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="description"> A description for this rule. Restricted to 140 chars. </param>
        /// <param name="service"> Service endpoint name. </param>
        /// <param name="serviceResources"> A list of service resources. </param>
        /// <param name="provisioningState"> The provisioning state of the service endpoint policy definition resource. </param>
        internal ServiceEndpointPolicyDefinitionData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, string description, string service, IList<string> serviceResources, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Etag = etag;
            Description = description;
            Service = service;
            ServiceResources = serviceResources;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> A description for this rule. Restricted to 140 chars. </summary>
        public string Description { get; set; }
        /// <summary> Service endpoint name. </summary>
        public string Service { get; set; }
        /// <summary> A list of service resources. </summary>
        public IList<string> ServiceResources { get; }
        /// <summary> The provisioning state of the service endpoint policy definition resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
