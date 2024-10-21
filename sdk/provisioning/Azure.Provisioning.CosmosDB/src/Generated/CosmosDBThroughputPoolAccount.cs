// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// CosmosDBThroughputPoolAccount.
/// </summary>
public partial class CosmosDBThroughputPoolAccount : ProvisionableResource
{
    /// <summary>
    /// Cosmos DB global database account in a Throughput Pool.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The location of  global database account in the throughputPool.
    /// </summary>
    public BicepValue<AzureLocation> AccountLocation { get => _accountLocation; set => _accountLocation.Assign(value); }
    private readonly BicepValue<AzureLocation> _accountLocation;

    /// <summary>
    /// The resource identifier of global database account in the
    /// throughputPool.
    /// </summary>
    public BicepValue<ResourceIdentifier> AccountResourceIdentifier { get => _accountResourceIdentifier; set => _accountResourceIdentifier.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _accountResourceIdentifier;

    /// <summary>
    /// A provisioning state of the ThroughputPool Account.
    /// </summary>
    public BicepValue<CosmosDBStatus> ProvisioningState { get => _provisioningState; set => _provisioningState.Assign(value); }
    private readonly BicepValue<CosmosDBStatus> _provisioningState;

    /// <summary>
    /// The instance id of global database account in the throughputPool.
    /// </summary>
    public BicepValue<string> AccountInstanceId { get => _accountInstanceId; }
    private readonly BicepValue<string> _accountInstanceId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent CosmosDBThroughputPool.
    /// </summary>
    public CosmosDBThroughputPool? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<CosmosDBThroughputPool> _parent;

    /// <summary>
    /// Creates a new CosmosDBThroughputPoolAccount.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CosmosDBThroughputPoolAccount
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CosmosDBThroughputPoolAccount.</param>
    public CosmosDBThroughputPoolAccount(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DocumentDB/throughputPools/throughputPoolAccounts", resourceVersion)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _accountLocation = BicepValue<AzureLocation>.DefineProperty(this, "AccountLocation", ["properties", "accountLocation"]);
        _accountResourceIdentifier = BicepValue<ResourceIdentifier>.DefineProperty(this, "AccountResourceIdentifier", ["properties", "accountResourceIdentifier"]);
        _provisioningState = BicepValue<CosmosDBStatus>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"]);
        _accountInstanceId = BicepValue<string>.DefineProperty(this, "AccountInstanceId", ["properties", "accountInstanceId"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<CosmosDBThroughputPool>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported CosmosDBThroughputPoolAccount resource versions.
    /// </summary>
    public static class ResourceVersions
    {
    }
    /// <summary>
    /// Creates a reference to an existing CosmosDBThroughputPoolAccount.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CosmosDBThroughputPoolAccount
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CosmosDBThroughputPoolAccount.</param>
    /// <returns>The existing CosmosDBThroughputPoolAccount resource.</returns>
    public static CosmosDBThroughputPoolAccount FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
