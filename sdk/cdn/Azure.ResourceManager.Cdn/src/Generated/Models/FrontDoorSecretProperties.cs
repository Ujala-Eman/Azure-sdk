// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// The json object containing secret parameters
    /// Please note <see cref="FrontDoorSecretProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureFirstPartyManagedCertificateProperties"/>, <see cref="CustomerCertificateProperties"/>, <see cref="ManagedCertificateProperties"/> and <see cref="UriSigningKeyProperties"/>.
    /// </summary>
    public partial class FrontDoorSecretProperties
    {
        /// <summary> Initializes a new instance of FrontDoorSecretProperties. </summary>
        public FrontDoorSecretProperties()
        {
        }

        /// <summary> Initializes a new instance of FrontDoorSecretProperties. </summary>
        /// <param name="secretType"> The type of the secret resource. </param>
        internal FrontDoorSecretProperties(SecretType secretType)
        {
            SecretType = secretType;
        }

        /// <summary> The type of the secret resource. </summary>
        internal SecretType SecretType { get; set; }
    }
}
