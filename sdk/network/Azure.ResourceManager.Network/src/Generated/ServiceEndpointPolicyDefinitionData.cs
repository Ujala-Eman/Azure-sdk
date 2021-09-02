// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ServiceEndpointPolicyDefinition data model. </summary>
    public partial class ServiceEndpointPolicyDefinitionData : WritableSubResource
    {
        /// <summary> Initializes a new instance of ServiceEndpointPolicyDefinitionData. </summary>
        public ServiceEndpointPolicyDefinitionData()
        {
            ServiceResources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ServiceEndpointPolicyDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="description"> A description for this rule. Restricted to 140 chars. </param>
        /// <param name="service"> Service endpoint name. </param>
        /// <param name="serviceResources"> A list of service resources. </param>
        /// <param name="provisioningState"> The provisioning state of the service endpoint policy definition resource. </param>
        internal ServiceEndpointPolicyDefinitionData(string id, string name, string etag, string description, string service, IList<string> serviceResources, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Description = description;
            Service = service;
            ServiceResources = serviceResources;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A description for this rule. Restricted to 140 chars. </summary>
        public string Description { get; set; }
        /// <summary> Service endpoint name. </summary>
        public string Service { get; set; }
        /// <summary> A list of service resources. </summary>
        public IList<string> ServiceResources { get; }
        /// <summary> The provisioning state of the service endpoint policy definition resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
