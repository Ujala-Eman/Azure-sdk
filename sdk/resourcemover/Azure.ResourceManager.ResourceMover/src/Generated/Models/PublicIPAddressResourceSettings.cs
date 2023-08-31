// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the public IP address resource settings. </summary>
    public partial class PublicIPAddressResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of <see cref="PublicIPAddressResourceSettings"/>. </summary>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        public PublicIPAddressResourceSettings(string targetResourceName) : base(targetResourceName)
        {
            Argument.AssertNotNull(targetResourceName, nameof(targetResourceName));

            Tags = new ChangeTrackingDictionary<string, string>();
            ResourceType = "Microsoft.Network/publicIPAddresses";
        }

        /// <summary> Initializes a new instance of <see cref="PublicIPAddressResourceSettings"/>. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="domainNameLabel"> Gets or sets the domain name label. </param>
        /// <param name="fqdn"> Gets or sets the fully qualified domain name. </param>
        /// <param name="publicIPAllocationMethod"> Gets or sets public IP allocation method. </param>
        /// <param name="sku"> Gets or sets public IP sku. </param>
        /// <param name="zones"> Gets or sets public IP zones. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PublicIPAddressResourceSettings(string resourceType, string targetResourceName, IDictionary<string, string> tags, string domainNameLabel, string fqdn, string publicIPAllocationMethod, string sku, string zones, Dictionary<string, BinaryData> rawData) : base(resourceType, targetResourceName, rawData)
        {
            Tags = tags;
            DomainNameLabel = domainNameLabel;
            Fqdn = fqdn;
            PublicIPAllocationMethod = publicIPAllocationMethod;
            Sku = sku;
            Zones = zones;
            ResourceType = resourceType ?? "Microsoft.Network/publicIPAddresses";
        }

        /// <summary> Initializes a new instance of <see cref="PublicIPAddressResourceSettings"/> for deserialization. </summary>
        internal PublicIPAddressResourceSettings()
        {
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the domain name label. </summary>
        public string DomainNameLabel { get; set; }
        /// <summary> Gets or sets the fully qualified domain name. </summary>
        public string Fqdn { get; set; }
        /// <summary> Gets or sets public IP allocation method. </summary>
        public string PublicIPAllocationMethod { get; set; }
        /// <summary> Gets or sets public IP sku. </summary>
        public string Sku { get; set; }
        /// <summary> Gets or sets public IP zones. </summary>
        public string Zones { get; set; }
    }
}
