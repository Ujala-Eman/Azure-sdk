// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Sku information related properties of a server.
/// </summary>
public partial class PostgreSqlFlexibleServerSku : ProvisionableConstruct
{
    /// <summary>
    /// The name of the sku, typically, tier + family + cores, e.g.
    /// Standard_D4s_v3.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The tier of the particular SKU, e.g. Burstable.
    /// </summary>
    public BicepValue<PostgreSqlFlexibleServerSkuTier> Tier 
    {
        get { Initialize(); return _tier!; }
        set { Initialize(); _tier!.Assign(value); }
    }
    private BicepValue<PostgreSqlFlexibleServerSkuTier>? _tier;

    /// <summary>
    /// Creates a new PostgreSqlFlexibleServerSku.
    /// </summary>
    public PostgreSqlFlexibleServerSku()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of PostgreSqlFlexibleServerSku.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _tier = DefineProperty<PostgreSqlFlexibleServerSkuTier>("Tier", ["tier"]);
    }
}
