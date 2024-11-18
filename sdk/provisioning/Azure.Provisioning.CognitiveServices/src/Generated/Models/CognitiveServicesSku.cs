// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// The resource model definition representing SKU.
/// </summary>
public partial class CognitiveServicesSku : ProvisionableConstruct
{
    /// <summary>
    /// The name of the SKU. Ex - P3. It is typically a letter+number code.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// This field is required to be implemented by the Resource Provider if
    /// the service has more than one tier, but is not required on a PUT.
    /// </summary>
    public BicepValue<CognitiveServicesSkuTier> Tier 
    {
        get { Initialize(); return _tier!; }
        set { Initialize(); _tier!.Assign(value); }
    }
    private BicepValue<CognitiveServicesSkuTier>? _tier;

    /// <summary>
    /// The SKU size. When the name field is the combination of tier and some
    /// other value, this would be the standalone code.
    /// </summary>
    public BicepValue<string> Size 
    {
        get { Initialize(); return _size!; }
        set { Initialize(); _size!.Assign(value); }
    }
    private BicepValue<string>? _size;

    /// <summary>
    /// If the service has different generations of hardware, for the same SKU,
    /// then that can be captured here.
    /// </summary>
    public BicepValue<string> Family 
    {
        get { Initialize(); return _family!; }
        set { Initialize(); _family!.Assign(value); }
    }
    private BicepValue<string>? _family;

    /// <summary>
    /// If the SKU supports scale out/in then the capacity integer should be
    /// included. If scale out/in is not possible for the resource this may be
    /// omitted.
    /// </summary>
    public BicepValue<int> Capacity 
    {
        get { Initialize(); return _capacity!; }
        set { Initialize(); _capacity!.Assign(value); }
    }
    private BicepValue<int>? _capacity;

    /// <summary>
    /// Creates a new CognitiveServicesSku.
    /// </summary>
    public CognitiveServicesSku()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of CognitiveServicesSku.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _tier = DefineProperty<CognitiveServicesSkuTier>("Tier", ["tier"]);
        _size = DefineProperty<string>("Size", ["size"]);
        _family = DefineProperty<string>("Family", ["family"]);
        _capacity = DefineProperty<int>("Capacity", ["capacity"]);
    }
}
