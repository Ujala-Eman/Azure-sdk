// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.AppConfiguration;

/// <summary>
/// AppConfigurationReplica.
/// </summary>
public partial class AppConfigurationReplica : Resource
{
    /// <summary>
    /// The name of the replica.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The location of the replica.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The URI of the replica where the replica API will be available.
    /// </summary>
    public BicepValue<string> Endpoint { get => _endpoint; }
    private readonly BicepValue<string> _endpoint;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The provisioning state of the replica.
    /// </summary>
    public BicepValue<AppConfigurationReplicaProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<AppConfigurationReplicaProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent AppConfigurationStore.
    /// </summary>
    public AppConfigurationStore? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<AppConfigurationStore> _parent;

    /// <summary>
    /// Creates a new AppConfigurationReplica.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the AppConfigurationReplica resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppConfigurationReplica.</param>
    public AppConfigurationReplica(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.AppConfiguration/configurationStores/replicas", resourceVersion ?? "2024-05-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"]);
        _endpoint = BicepValue<string>.DefineProperty(this, "Endpoint", ["properties", "endpoint"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<AppConfigurationReplicaProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<AppConfigurationStore>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported AppConfigurationReplica resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";

        /// <summary>
        /// 2023-03-01.
        /// </summary>
        public static readonly string V2023_03_01 = "2023-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing AppConfigurationReplica.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the AppConfigurationReplica resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppConfigurationReplica.</param>
    /// <returns>The existing AppConfigurationReplica resource.</returns>
    public static AppConfigurationReplica FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this AppConfigurationReplica resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers);
}
