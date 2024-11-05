// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Custom Domain of a Container App.
/// </summary>
public partial class ContainerAppCustomDomain : ProvisionableConstruct
{
    /// <summary>
    /// Hostname.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Custom Domain binding type.
    /// </summary>
    public BicepValue<ContainerAppCustomDomainBindingType> BindingType 
    {
        get { Initialize(); return _bindingType!; }
        set { Initialize(); _bindingType!.Assign(value); }
    }
    private BicepValue<ContainerAppCustomDomainBindingType>? _bindingType;

    /// <summary>
    /// Resource Id of the Certificate to be bound to this hostname. Must exist
    /// in the Managed Environment.
    /// </summary>
    public BicepValue<ResourceIdentifier> CertificateId 
    {
        get { Initialize(); return _certificateId!; }
        set { Initialize(); _certificateId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _certificateId;

    /// <summary>
    /// Creates a new ContainerAppCustomDomain.
    /// </summary>
    public ContainerAppCustomDomain()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerAppCustomDomain.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _bindingType = DefineProperty<ContainerAppCustomDomainBindingType>("BindingType", ["bindingType"]);
        _certificateId = DefineProperty<ResourceIdentifier>("CertificateId", ["certificateId"]);
    }
}
