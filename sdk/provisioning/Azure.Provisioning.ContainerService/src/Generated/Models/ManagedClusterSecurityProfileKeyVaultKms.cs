// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Azure Key Vault key management service settings for the security profile.
/// </summary>
public partial class ManagedClusterSecurityProfileKeyVaultKms : ProvisionableConstruct
{
    /// <summary>
    /// Whether to enable Azure Key Vault key management service. The default
    /// is false.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// Identifier of Azure Key Vault key. See [key identifier
    /// format](https://docs.microsoft.com/en-us/azure/key-vault/general/about-keys-secrets-certificates#vault-name-and-object-name)
    /// for more details. When Azure Key Vault key management service is
    /// enabled, this field is required and must be a valid key identifier.
    /// When Azure Key Vault key management service is disabled, leave the
    /// field empty.
    /// </summary>
    public BicepValue<string> KeyId { get => _keyId; set => _keyId.Assign(value); }
    private readonly BicepValue<string> _keyId;

    /// <summary>
    /// Network access of key vault. The possible values are `Public` and
    /// `Private`. `Public` means the key vault allows public access from all
    /// networks. `Private` means the key vault disables public access and
    /// enables private link. The default value is `Public`.
    /// </summary>
    public BicepValue<ManagedClusterKeyVaultNetworkAccessType> KeyVaultNetworkAccess { get => _keyVaultNetworkAccess; set => _keyVaultNetworkAccess.Assign(value); }
    private readonly BicepValue<ManagedClusterKeyVaultNetworkAccessType> _keyVaultNetworkAccess;

    /// <summary>
    /// Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this
    /// field is required and must be a valid resource ID. When
    /// keyVaultNetworkAccess is `Public`, leave the field empty.
    /// </summary>
    public BicepValue<ResourceIdentifier> KeyVaultResourceId { get => _keyVaultResourceId; set => _keyVaultResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _keyVaultResourceId;

    /// <summary>
    /// Creates a new ManagedClusterSecurityProfileKeyVaultKms.
    /// </summary>
    public ManagedClusterSecurityProfileKeyVaultKms()
    {
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["enabled"]);
        _keyId = BicepValue<string>.DefineProperty(this, "KeyId", ["keyId"]);
        _keyVaultNetworkAccess = BicepValue<ManagedClusterKeyVaultNetworkAccessType>.DefineProperty(this, "KeyVaultNetworkAccess", ["keyVaultNetworkAccess"]);
        _keyVaultResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "KeyVaultResourceId", ["keyVaultResourceId"]);
    }
}
