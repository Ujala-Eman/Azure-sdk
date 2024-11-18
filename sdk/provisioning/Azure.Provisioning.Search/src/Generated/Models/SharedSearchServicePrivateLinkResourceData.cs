// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Search;

/// <summary>
/// A class representing the SharedSearchServicePrivateLinkResource data model.
/// Describes a shared private link resource managed by the Azure
/// AI Search service.
/// </summary>
public partial class SharedSearchServicePrivateLinkResourceData : ProvisionableConstruct
{
    /// <summary>
    /// Describes the properties of a shared private link resource managed by
    /// the Azure AI Search service.
    /// </summary>
    public SharedSearchServicePrivateLinkResourceProperties Properties 
    {
        get { Initialize(); return _properties!; }
        set { Initialize(); AssignOrReplace(ref _properties, value); }
    }
    private SharedSearchServicePrivateLinkResourceProperties? _properties;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new SharedSearchServicePrivateLinkResourceData.
    /// </summary>
    public SharedSearchServicePrivateLinkResourceData()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// SharedSearchServicePrivateLinkResourceData.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _properties = DefineModelProperty<SharedSearchServicePrivateLinkResourceProperties>("Properties", ["properties"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }
}
