// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// User assigned identity properties.
/// </summary>
public partial class UserAssignedIdentityDetails : ProvisionableConstruct
{
    /// <summary>
    /// The principal ID of the assigned identity.
    /// </summary>
    public BicepValue<Guid> PrincipalId 
    {
        get { Initialize(); return _principalId!; }
    }
    private BicepValue<Guid>? _principalId;

    /// <summary>
    /// The client ID of the assigned identity.
    /// </summary>
    public BicepValue<Guid> ClientId 
    {
        get { Initialize(); return _clientId!; }
    }
    private BicepValue<Guid>? _clientId;

    /// <summary>
    /// Creates a new UserAssignedIdentityDetails.
    /// </summary>
    public UserAssignedIdentityDetails()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of UserAssignedIdentityDetails.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _principalId = DefineProperty<Guid>("PrincipalId", ["principalId"], isOutput: true);
        _clientId = DefineProperty<Guid>("ClientId", ["clientId"], isOutput: true);
    }
}
