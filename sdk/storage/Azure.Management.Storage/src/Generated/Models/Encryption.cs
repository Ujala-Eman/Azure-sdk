// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> The encryption settings on the storage account. </summary>
    public partial class Encryption
    {
        /// <summary> Initializes a new instance of Encryption. </summary>
        public Encryption()
        {
        }

        /// <summary> Initializes a new instance of Encryption. </summary>
        /// <param name="services"> List of services which support encryption. </param>
        /// <param name="keySource"> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault. </param>
        /// <param name="keyVaultProperties"> Properties provided by key vault. </param>
        internal Encryption(EncryptionServices services, KeySource keySource, KeyVaultProperties keyVaultProperties)
        {
            Services = services;
            KeySource = keySource;
            KeyVaultProperties = keyVaultProperties;
        }

        /// <summary> List of services which support encryption. </summary>
        public EncryptionServices Services { get; set; }
        /// <summary> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault. </summary>
        public KeySource KeySource { get; set; }
        /// <summary> Properties provided by key vault. </summary>
        public KeyVaultProperties KeyVaultProperties { get; set; }
    }
}
