// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// Sku change info of account.
/// </summary>
public partial class CognitiveServicesSkuChangeInfo : ProvisionableConstruct
{
    /// <summary>
    /// Gets the count of downgrades.
    /// </summary>
    public BicepValue<float> CountOfDowngrades 
    {
        get { Initialize(); return _countOfDowngrades!; }
    }
    private BicepValue<float>? _countOfDowngrades;

    /// <summary>
    /// Gets the count of upgrades after downgrades.
    /// </summary>
    public BicepValue<float> CountOfUpgradesAfterDowngrades 
    {
        get { Initialize(); return _countOfUpgradesAfterDowngrades!; }
    }
    private BicepValue<float>? _countOfUpgradesAfterDowngrades;

    /// <summary>
    /// Gets the last change date.
    /// </summary>
    public BicepValue<DateTimeOffset> LastChangedOn 
    {
        get { Initialize(); return _lastChangedOn!; }
    }
    private BicepValue<DateTimeOffset>? _lastChangedOn;

    /// <summary>
    /// Creates a new CognitiveServicesSkuChangeInfo.
    /// </summary>
    public CognitiveServicesSkuChangeInfo()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// CognitiveServicesSkuChangeInfo.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _countOfDowngrades = DefineProperty<float>("CountOfDowngrades", ["countOfDowngrades"], isOutput: true);
        _countOfUpgradesAfterDowngrades = DefineProperty<float>("CountOfUpgradesAfterDowngrades", ["countOfUpgradesAfterDowngrades"], isOutput: true);
        _lastChangedOn = DefineProperty<DateTimeOffset>("LastChangedOn", ["lastChangeDate"], isOutput: true);
    }
}
