// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> Storage SKU and its properties. </summary>
    public partial class SkuInformation
    {
        /// <summary> Initializes a new instance of SkuInformation. </summary>
        internal SkuInformation()
        {
        }

        /// <summary> Initializes a new instance of SkuInformation. </summary>
        /// <param name="name"> The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType. </param>
        /// <param name="tier"> The SKU tier. This is based on the SKU name. </param>
        /// <param name="resourceType"> The type of the resource, usually it is &apos;storageAccounts&apos;. </param>
        /// <param name="kind"> Indicates the type of storage account. </param>
        /// <param name="locations"> The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). </param>
        /// <param name="capabilities"> The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc. </param>
        /// <param name="restrictions"> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </param>
        internal SkuInformation(SkuName name, SkuTier? tier, string resourceType, Kind? kind, IList<string> locations, IList<SKUCapability> capabilities, IList<Restriction> restrictions)
        {
            Name = name;
            Tier = tier;
            ResourceType = resourceType;
            Kind = kind;
            Locations = locations;
            Capabilities = capabilities;
            Restrictions = restrictions;
        }

        /// <summary> The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType. </summary>
        public SkuName Name { get; internal set; }
        /// <summary> The SKU tier. This is based on the SKU name. </summary>
        public SkuTier? Tier { get; internal set; }
        /// <summary> The type of the resource, usually it is &apos;storageAccounts&apos;. </summary>
        public string ResourceType { get; internal set; }
        /// <summary> Indicates the type of storage account. </summary>
        public Kind? Kind { get; internal set; }
        /// <summary> The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). </summary>
        public IList<string> Locations { get; internal set; }
        /// <summary> The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc. </summary>
        public IList<SKUCapability> Capabilities { get; internal set; }
        /// <summary> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </summary>
        public IList<Restriction> Restrictions { get; internal set; }
    }
}
