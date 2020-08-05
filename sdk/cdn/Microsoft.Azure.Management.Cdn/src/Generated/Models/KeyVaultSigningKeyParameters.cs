// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the parameters for using a user's KeyVault for URL Signing
    /// Key.
    /// </summary>
    public partial class KeyVaultSigningKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultSigningKeyParameters
        /// class.
        /// </summary>
        public KeyVaultSigningKeyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultSigningKeyParameters
        /// class.
        /// </summary>
        /// <param name="subscriptionId">Subscription Id of the user's Key
        /// Vault containing the secret</param>
        /// <param name="resourceGroupName">Resource group of the user's Key
        /// Vault containing the secret</param>
        /// <param name="vaultName">The name of the user's Key Vault containing
        /// the secret</param>
        /// <param name="secretName">The name of secret in Key Vault.</param>
        /// <param name="secretVersion">The version(GUID) of secret in Key
        /// Vault.</param>
        public KeyVaultSigningKeyParameters(string subscriptionId, string resourceGroupName, string vaultName, string secretName, string secretVersion)
        {
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            VaultName = vaultName;
            SecretName = secretName;
            SecretVersion = secretVersion;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for KeyVaultSigningKeyParameters class.
        /// </summary>
        static KeyVaultSigningKeyParameters()
        {
            Odatatype = "#Microsoft.Azure.Cdn.Models.KeyVaultSigningKeyParameters";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets subscription Id of the user's Key Vault containing the
        /// secret
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets resource group of the user's Key Vault containing the
        /// secret
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the name of the user's Key Vault containing the secret
        /// </summary>
        [JsonProperty(PropertyName = "vaultName")]
        public string VaultName { get; set; }

        /// <summary>
        /// Gets or sets the name of secret in Key Vault.
        /// </summary>
        [JsonProperty(PropertyName = "secretName")]
        public string SecretName { get; set; }

        /// <summary>
        /// Gets or sets the version(GUID) of secret in Key Vault.
        /// </summary>
        [JsonProperty(PropertyName = "secretVersion")]
        public string SecretVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.type")]
        public static string Odatatype { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubscriptionId");
            }
            if (ResourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceGroupName");
            }
            if (VaultName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VaultName");
            }
            if (SecretName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretName");
            }
            if (SecretVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretVersion");
            }
        }
    }
}
