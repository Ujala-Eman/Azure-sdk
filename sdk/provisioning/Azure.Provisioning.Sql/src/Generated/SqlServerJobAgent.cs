// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlServerJobAgent.
/// </summary>
public partial class SqlServerJobAgent : ProvisionableResource
{
    /// <summary>
    /// The name of the job agent to be created or updated.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Resource ID of the database to store job metadata in.
    /// </summary>
    public BicepValue<ResourceIdentifier> DatabaseId { get => _databaseId; set => _databaseId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _databaseId;

    /// <summary>
    /// The name and tier of the SKU.
    /// </summary>
    public BicepValue<SqlSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<SqlSku> _sku;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The state of the job agent.
    /// </summary>
    public BicepValue<JobAgentState> State { get => _state; }
    private readonly BicepValue<JobAgentState> _state;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlServer> _parent;

    /// <summary>
    /// Creates a new SqlServerJobAgent.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerJobAgent resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerJobAgent.</param>
    public SqlServerJobAgent(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/jobAgents", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _databaseId = BicepValue<ResourceIdentifier>.DefineProperty(this, "DatabaseId", ["properties", "databaseId"]);
        _sku = BicepValue<SqlSku>.DefineProperty(this, "Sku", ["sku"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _state = BicepValue<JobAgentState>.DefineProperty(this, "State", ["properties", "state"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlServerJobAgent resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlServerJobAgent.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerJobAgent resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerJobAgent.</param>
    /// <returns>The existing SqlServerJobAgent resource.</returns>
    public static SqlServerJobAgent FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
