// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> Parameters for creating an attestation provider. </summary>
    public partial class AttestationProviderCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of AttestationProviderCreateOrUpdateContent. </summary>
        /// <param name="location"> The supported Azure location where the attestation provider should be created. </param>
        /// <param name="properties"> Properties of the attestation provider. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public AttestationProviderCreateOrUpdateContent(AzureLocation location, AttestationServiceCreationSpecificParams properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            Properties = properties;
        }

        /// <summary> The supported Azure location where the attestation provider should be created. </summary>
        public AzureLocation Location { get; }
        /// <summary> The tags that will be assigned to the attestation provider. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Properties of the attestation provider. </summary>
        public AttestationServiceCreationSpecificParams Properties { get; }
    }
}
