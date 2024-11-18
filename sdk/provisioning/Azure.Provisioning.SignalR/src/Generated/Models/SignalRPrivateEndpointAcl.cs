// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// ACL for a private endpoint.
/// </summary>
public partial class SignalRPrivateEndpointAcl : SignalRNetworkAcl
{
    /// <summary>
    /// Name of the private endpoint connection.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Creates a new SignalRPrivateEndpointAcl.
    /// </summary>
    public SignalRPrivateEndpointAcl() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SignalRPrivateEndpointAcl.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
    }
}
