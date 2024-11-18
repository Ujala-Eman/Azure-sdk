// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.Net;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// PostgreSqlFlexibleServerFirewallRule.
/// </summary>
public partial class PostgreSqlFlexibleServerFirewallRule : ProvisionableResource
{
    /// <summary>
    /// The name of the server firewall rule.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The end IP address of the server firewall rule. Must be IPv4 format.
    /// </summary>
    public BicepValue<IPAddress> EndIPAddress 
    {
        get { Initialize(); return _endIPAddress!; }
        set { Initialize(); _endIPAddress!.Assign(value); }
    }
    private BicepValue<IPAddress>? _endIPAddress;

    /// <summary>
    /// The start IP address of the server firewall rule. Must be IPv4 format.
    /// </summary>
    public BicepValue<IPAddress> StartIPAddress 
    {
        get { Initialize(); return _startIPAddress!; }
        set { Initialize(); _startIPAddress!.Assign(value); }
    }
    private BicepValue<IPAddress>? _startIPAddress;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent PostgreSqlFlexibleServer.
    /// </summary>
    public PostgreSqlFlexibleServer? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<PostgreSqlFlexibleServer>? _parent;

    /// <summary>
    /// Creates a new PostgreSqlFlexibleServerFirewallRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// PostgreSqlFlexibleServerFirewallRule resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerFirewallRule.</param>
    public PostgreSqlFlexibleServerFirewallRule(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DBforPostgreSQL/flexibleServers/firewallRules", resourceVersion ?? "2024-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// PostgreSqlFlexibleServerFirewallRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _endIPAddress = DefineProperty<IPAddress>("EndIPAddress", ["properties", "endIpAddress"], isRequired: true);
        _startIPAddress = DefineProperty<IPAddress>("StartIPAddress", ["properties", "startIpAddress"], isRequired: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<PostgreSqlFlexibleServer>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PostgreSqlFlexibleServerFirewallRule resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-01.
        /// </summary>
        public static readonly string V2024_08_01 = "2024-08-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing PostgreSqlFlexibleServerFirewallRule.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// PostgreSqlFlexibleServerFirewallRule resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlFlexibleServerFirewallRule.</param>
    /// <returns>The existing PostgreSqlFlexibleServerFirewallRule resource.</returns>
    public static PostgreSqlFlexibleServerFirewallRule FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
