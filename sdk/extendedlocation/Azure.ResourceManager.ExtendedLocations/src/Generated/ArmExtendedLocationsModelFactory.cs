// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ExtendedLocations;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmExtendedLocationsModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedLocations.CustomLocationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned, None. </param>
        /// <param name="authentication"> This is optional input that contains the authentication that should be used to generate the namespace. </param>
        /// <param name="clusterExtensionIds"> Contains the reference to the add-on that contains charts to deploy CRDs and operators. </param>
        /// <param name="displayName"> Display name for the Custom Locations location. </param>
        /// <param name="hostResourceId"> Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions. </param>
        /// <param name="hostType"> Type of host the Custom Locations is referencing (Kubernetes, etc...). </param>
        /// <param name="namespace"> Kubernetes namespace that will be created on the specified cluster. </param>
        /// <param name="provisioningState"> Provisioning State for the Custom Location. </param>
        /// <returns> A new <see cref="ExtendedLocations.CustomLocationData"/> instance for mocking. </returns>
        public static CustomLocationData CustomLocationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, CustomLocationAuthentication authentication = null, IEnumerable<ResourceIdentifier> clusterExtensionIds = null, string displayName = null, ResourceIdentifier hostResourceId = null, CustomLocationHostType? hostType = null, string @namespace = null, string provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();
            clusterExtensionIds ??= new List<ResourceIdentifier>();

            return new CustomLocationData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                identity,
                authentication,
                clusterExtensionIds?.ToList(),
                displayName,
                hostResourceId,
                hostType,
                @namespace,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CustomLocationEnabledResourceType"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="clusterExtensionId"> Cluster Extension ID. </param>
        /// <param name="extensionType"> Cluster Extension Type. </param>
        /// <param name="typesMetadata"> Metadata of the Resource Type. </param>
        /// <returns> A new <see cref="Models.CustomLocationEnabledResourceType"/> instance for mocking. </returns>
        public static CustomLocationEnabledResourceType CustomLocationEnabledResourceType(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier clusterExtensionId = null, string extensionType = null, IEnumerable<CustomLocationEnabledResourceTypeMetadata> typesMetadata = null)
        {
            typesMetadata ??= new List<CustomLocationEnabledResourceTypeMetadata>();

            return new CustomLocationEnabledResourceType(
                id,
                name,
                resourceType,
                systemData,
                clusterExtensionId,
                extensionType,
                typesMetadata?.ToList(),
                serializedAdditionalRawData: null);
        }
    }
}
