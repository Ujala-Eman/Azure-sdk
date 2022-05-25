// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Azure Firewall FQDN Tag Resource. </summary>
    public partial class AzureFirewallFqdnTag : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of AzureFirewallFqdnTag. </summary>
        public AzureFirewallFqdnTag()
        {
        }

        /// <summary> Initializes a new instance of AzureFirewallFqdnTag. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the Azure firewall FQDN tag resource. </param>
        /// <param name="fqdnTagName"> The name of this FQDN Tag. </param>
        internal AzureFirewallFqdnTag(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, string etag, NetworkProvisioningState? provisioningState, string fqdnTagName) : base(id, name, resourceType, location, tags)
        {
            Etag = etag;
            ProvisioningState = provisioningState;
            FqdnTagName = fqdnTagName;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The provisioning state of the Azure firewall FQDN tag resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The name of this FQDN Tag. </summary>
        public string FqdnTagName { get; }
    }
}
