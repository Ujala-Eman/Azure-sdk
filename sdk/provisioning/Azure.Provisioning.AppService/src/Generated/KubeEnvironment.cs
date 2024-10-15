// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// KubeEnvironment.
/// </summary>
public partial class KubeEnvironment : Resource
{
    /// <summary>
    /// Name of the Kubernetes Environment.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets or sets the aks resource id.
    /// </summary>
    public BicepValue<ResourceIdentifier> AksResourceId { get => _aksResourceId; set => _aksResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _aksResourceId;

    /// <summary>
    /// Cluster configuration which enables the log daemon to export
    /// app logs to a destination. Currently only
    /// &quot;log-analytics&quot; is             supported
    /// </summary>
    public BicepValue<AppLogsConfiguration> AppLogsConfiguration { get => _appLogsConfiguration; set => _appLogsConfiguration.Assign(value); }
    private readonly BicepValue<AppLogsConfiguration> _appLogsConfiguration;

    /// <summary>
    /// Cluster configuration which determines the ARC cluster
    /// components types. Eg: Choosing between BuildService kind,
    /// FrontEnd Service ArtifactsStorageType etc.
    /// </summary>
    public BicepValue<ArcConfiguration> ArcConfiguration { get => _arcConfiguration; set => _arcConfiguration.Assign(value); }
    private readonly BicepValue<ArcConfiguration> _arcConfiguration;

    /// <summary>
    /// Cluster configuration for Container Apps Environments to configure Dapr
    /// Instrumentation Key and VNET Configuration.
    /// </summary>
    public BicepValue<ContainerAppsConfiguration> ContainerAppsConfiguration { get => _containerAppsConfiguration; set => _containerAppsConfiguration.Assign(value); }
    private readonly BicepValue<ContainerAppsConfiguration> _containerAppsConfiguration;

    /// <summary>
    /// Type of Kubernetes Environment. Only supported for Container App
    /// Environments with value as Managed.
    /// </summary>
    public BicepValue<string> EnvironmentType { get => _environmentType; set => _environmentType.Assign(value); }
    private readonly BicepValue<string> _environmentType;

    /// <summary>
    /// Extended Location.
    /// </summary>
    public BicepValue<ExtendedAzureLocation> ExtendedLocation { get => _extendedLocation; set => _extendedLocation.Assign(value); }
    private readonly BicepValue<ExtendedAzureLocation> _extendedLocation;

    /// <summary>
    /// Only visible within Vnet/Subnet.
    /// </summary>
    public BicepValue<bool> IsInternalLoadBalancerEnabled { get => _isInternalLoadBalancerEnabled; set => _isInternalLoadBalancerEnabled.Assign(value); }
    private readonly BicepValue<bool> _isInternalLoadBalancerEnabled;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Static IP of the KubeEnvironment.
    /// </summary>
    public BicepValue<string> StaticIP { get => _staticIP; set => _staticIP.Assign(value); }
    private readonly BicepValue<string> _staticIP;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Default Domain Name for the cluster.
    /// </summary>
    public BicepValue<string> DefaultDomain { get => _defaultDomain; }
    private readonly BicepValue<string> _defaultDomain;

    /// <summary>
    /// Any errors that occurred during deployment or deployment validation.
    /// </summary>
    public BicepValue<string> DeploymentErrors { get => _deploymentErrors; }
    private readonly BicepValue<string> _deploymentErrors;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the Kubernetes Environment.
    /// </summary>
    public BicepValue<KubeEnvironmentProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<KubeEnvironmentProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new KubeEnvironment.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the KubeEnvironment resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KubeEnvironment.</param>
    public KubeEnvironment(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Web/kubeEnvironments", resourceVersion ?? "2021-03-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _aksResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "AksResourceId", ["properties", "aksResourceID"]);
        _appLogsConfiguration = BicepValue<AppLogsConfiguration>.DefineProperty(this, "AppLogsConfiguration", ["properties", "appLogsConfiguration"]);
        _arcConfiguration = BicepValue<ArcConfiguration>.DefineProperty(this, "ArcConfiguration", ["properties", "arcConfiguration"]);
        _containerAppsConfiguration = BicepValue<ContainerAppsConfiguration>.DefineProperty(this, "ContainerAppsConfiguration", ["properties", "containerAppsConfiguration"]);
        _environmentType = BicepValue<string>.DefineProperty(this, "EnvironmentType", ["properties", "environmentType"]);
        _extendedLocation = BicepValue<ExtendedAzureLocation>.DefineProperty(this, "ExtendedLocation", ["extendedLocation"]);
        _isInternalLoadBalancerEnabled = BicepValue<bool>.DefineProperty(this, "IsInternalLoadBalancerEnabled", ["properties", "internalLoadBalancerEnabled"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _staticIP = BicepValue<string>.DefineProperty(this, "StaticIP", ["properties", "staticIp"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _defaultDomain = BicepValue<string>.DefineProperty(this, "DefaultDomain", ["properties", "defaultDomain"], isOutput: true);
        _deploymentErrors = BicepValue<string>.DefineProperty(this, "DeploymentErrors", ["properties", "deploymentErrors"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<KubeEnvironmentProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported KubeEnvironment resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing KubeEnvironment.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the KubeEnvironment resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KubeEnvironment.</param>
    /// <returns>The existing KubeEnvironment resource.</returns>
    public static KubeEnvironment FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
