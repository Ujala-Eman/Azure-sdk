// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// SKU name to specify whether the key vault is a standard vault or a premium
/// vault.
/// </summary>
public enum KeyVaultSkuName
{
    /// <summary>
    /// standard.
    /// </summary>
    [DataMember(Name = "standard")]
    Standard,

    /// <summary>
    /// premium.
    /// </summary>
    [DataMember(Name = "premium")]
    Premium,
}
