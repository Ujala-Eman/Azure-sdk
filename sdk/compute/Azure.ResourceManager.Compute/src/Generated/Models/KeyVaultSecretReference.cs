// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a reference to Key Vault Secret. </summary>
    public partial class KeyVaultSecretReference
    {
        /// <summary> Initializes a new instance of <see cref="KeyVaultSecretReference"/>. </summary>
        /// <param name="secretUri"> The URL referencing a secret in a Key Vault. </param>
        /// <param name="sourceVault"> The relative URL of the Key Vault containing the secret. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretUri"/> or <paramref name="sourceVault"/> is null. </exception>
        public KeyVaultSecretReference(Uri secretUri, WritableSubResource sourceVault)
        {
            if (secretUri == null)
            {
                throw new ArgumentNullException(nameof(secretUri));
            }
            if (sourceVault == null)
            {
                throw new ArgumentNullException(nameof(sourceVault));
            }

            SecretUri = secretUri;
            SourceVault = sourceVault;
        }

        /// <summary> The URL referencing a secret in a Key Vault. </summary>
        public Uri SecretUri { get; set; }
        /// <summary> The relative URL of the Key Vault containing the secret. </summary>
        internal WritableSubResource SourceVault { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SourceVaultId
        {
            get => SourceVault is null ? default : SourceVault.Id;
            set
            {
                if (SourceVault is null)
                    SourceVault = new WritableSubResource();
                SourceVault.Id = value;
            }
        }
    }
}
