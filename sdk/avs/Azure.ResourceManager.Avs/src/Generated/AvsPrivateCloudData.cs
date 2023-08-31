// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the AvsPrivateCloud data model.
    /// A private cloud resource
    /// </summary>
    public partial class AvsPrivateCloudData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The private cloud SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public AvsPrivateCloudData(AzureLocation location, AvsSku sku) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
            IdentitySources = new ChangeTrackingList<SingleSignOnIdentitySource>();
            ExternalCloudLinks = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The private cloud SKU. </param>
        /// <param name="identity"> The identity of the private cloud, if configured. Current supported identity types: SystemAssigned, None. </param>
        /// <param name="managementCluster"> The default cluster used for management. </param>
        /// <param name="internet"> Connectivity to internet is enabled or disabled. </param>
        /// <param name="identitySources"> vCenter Single Sign On Identity Sources. </param>
        /// <param name="availability"> Properties describing how the cloud is distributed across availability zones. </param>
        /// <param name="encryption"> Customer managed key encryption, can be enabled or disabled. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="circuit"> An ExpressRoute Circuit. </param>
        /// <param name="endpoints"> The endpoints. </param>
        /// <param name="networkBlock"> The block of addresses should be unique across VNet in your subscription as well as on-premise. Make sure the CIDR format is conformed to (A.B.C.D/X) where A,B,C,D are between 0 and 255, and X is between 0 and 22. </param>
        /// <param name="managementNetwork"> Network used to access vCenter Server and NSX-T Manager. </param>
        /// <param name="provisioningNetwork"> Used for virtual machine cold migration, cloning, and snapshot migration. </param>
        /// <param name="vMotionNetwork"> Used for live migration of virtual machines. </param>
        /// <param name="vCenterPassword"> Optionally, set the vCenter admin password when the private cloud is created. </param>
        /// <param name="nsxtPassword"> Optionally, set the NSX-T Manager password when the private cloud is created. </param>
        /// <param name="vCenterCertificateThumbprint"> Thumbprint of the vCenter Server SSL certificate. </param>
        /// <param name="nsxtCertificateThumbprint"> Thumbprint of the NSX-T Manager SSL certificate. </param>
        /// <param name="externalCloudLinks"> Array of cloud link IDs from other clouds that connect to this one. </param>
        /// <param name="secondaryCircuit"> A secondary expressRoute circuit from a separate AZ. Only present in a stretched private cloud. </param>
        /// <param name="nsxPublicIPQuotaRaised"> Flag to indicate whether the private cloud has the quota for provisioned NSX Public IP count raised from 64 to 1024. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsPrivateCloudData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, AvsSku sku, ManagedServiceIdentity identity, AvsManagementCluster managementCluster, InternetConnectivityState? internet, IList<SingleSignOnIdentitySource> identitySources, PrivateCloudAvailabilityProperties availability, CustomerManagedEncryption encryption, AvsPrivateCloudProvisioningState? provisioningState, ExpressRouteCircuit circuit, AvsPrivateCloudEndpoints endpoints, string networkBlock, string managementNetwork, string provisioningNetwork, string vMotionNetwork, string vCenterPassword, string nsxtPassword, string vCenterCertificateThumbprint, string nsxtCertificateThumbprint, IReadOnlyList<ResourceIdentifier> externalCloudLinks, ExpressRouteCircuit secondaryCircuit, NsxPublicIPQuotaRaisedEnum? nsxPublicIPQuotaRaised, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            ManagementCluster = managementCluster;
            Internet = internet;
            IdentitySources = identitySources;
            Availability = availability;
            Encryption = encryption;
            ProvisioningState = provisioningState;
            Circuit = circuit;
            Endpoints = endpoints;
            NetworkBlock = networkBlock;
            ManagementNetwork = managementNetwork;
            ProvisioningNetwork = provisioningNetwork;
            VMotionNetwork = vMotionNetwork;
            VCenterPassword = vCenterPassword;
            NsxtPassword = nsxtPassword;
            VCenterCertificateThumbprint = vCenterCertificateThumbprint;
            NsxtCertificateThumbprint = nsxtCertificateThumbprint;
            ExternalCloudLinks = externalCloudLinks;
            SecondaryCircuit = secondaryCircuit;
            NsxPublicIPQuotaRaised = nsxPublicIPQuotaRaised;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudData"/> for deserialization. </summary>
        internal AvsPrivateCloudData()
        {
        }

        /// <summary> The private cloud SKU. </summary>
        internal AvsSku Sku { get; set; }
        /// <summary> The name of the SKU. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new AvsSku(value);
        }

        /// <summary> The identity of the private cloud, if configured. Current supported identity types: SystemAssigned, None. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The default cluster used for management. </summary>
        public AvsManagementCluster ManagementCluster { get; set; }
        /// <summary> Connectivity to internet is enabled or disabled. </summary>
        public InternetConnectivityState? Internet { get; set; }
        /// <summary> vCenter Single Sign On Identity Sources. </summary>
        public IList<SingleSignOnIdentitySource> IdentitySources { get; }
        /// <summary> Properties describing how the cloud is distributed across availability zones. </summary>
        public PrivateCloudAvailabilityProperties Availability { get; set; }
        /// <summary> Customer managed key encryption, can be enabled or disabled. </summary>
        public CustomerManagedEncryption Encryption { get; set; }
        /// <summary> The provisioning state. </summary>
        public AvsPrivateCloudProvisioningState? ProvisioningState { get; }
        /// <summary> An ExpressRoute Circuit. </summary>
        public ExpressRouteCircuit Circuit { get; set; }
        /// <summary> The endpoints. </summary>
        public AvsPrivateCloudEndpoints Endpoints { get; }
        /// <summary> The block of addresses should be unique across VNet in your subscription as well as on-premise. Make sure the CIDR format is conformed to (A.B.C.D/X) where A,B,C,D are between 0 and 255, and X is between 0 and 22. </summary>
        public string NetworkBlock { get; set; }
        /// <summary> Network used to access vCenter Server and NSX-T Manager. </summary>
        public string ManagementNetwork { get; }
        /// <summary> Used for virtual machine cold migration, cloning, and snapshot migration. </summary>
        public string ProvisioningNetwork { get; }
        /// <summary> Used for live migration of virtual machines. </summary>
        public string VMotionNetwork { get; }
        /// <summary> Optionally, set the vCenter admin password when the private cloud is created. </summary>
        public string VCenterPassword { get; set; }
        /// <summary> Optionally, set the NSX-T Manager password when the private cloud is created. </summary>
        public string NsxtPassword { get; set; }
        /// <summary> Thumbprint of the vCenter Server SSL certificate. </summary>
        public string VCenterCertificateThumbprint { get; }
        /// <summary> Thumbprint of the NSX-T Manager SSL certificate. </summary>
        public string NsxtCertificateThumbprint { get; }
        /// <summary> Array of cloud link IDs from other clouds that connect to this one. </summary>
        public IReadOnlyList<ResourceIdentifier> ExternalCloudLinks { get; }
        /// <summary> A secondary expressRoute circuit from a separate AZ. Only present in a stretched private cloud. </summary>
        public ExpressRouteCircuit SecondaryCircuit { get; set; }
        /// <summary> Flag to indicate whether the private cloud has the quota for provisioned NSX Public IP count raised from 64 to 1024. </summary>
        public NsxPublicIPQuotaRaisedEnum? NsxPublicIPQuotaRaised { get; }
    }
}
