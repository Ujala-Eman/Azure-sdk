// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.KubernetesConfiguration;

/// <summary>
/// KubernetesSourceControlConfiguration.
/// </summary>
public partial class KubernetesSourceControlConfiguration : ProvisionableResource
{
    /// <summary>
    /// Name of the Source Control Configuration.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Name-value pairs of protected configuration settings for the
    /// configuration.
    /// </summary>
    public BicepDictionary<string> ConfigurationProtectedSettings 
    {
        get { Initialize(); return _configurationProtectedSettings!; }
        set { Initialize(); _configurationProtectedSettings!.Assign(value); }
    }
    private BicepDictionary<string>? _configurationProtectedSettings;

    /// <summary>
    /// Properties for Helm operator.
    /// </summary>
    public HelmOperatorProperties HelmOperatorProperties 
    {
        get { Initialize(); return _helmOperatorProperties!; }
        set { Initialize(); AssignOrReplace(ref _helmOperatorProperties, value); }
    }
    private HelmOperatorProperties? _helmOperatorProperties;

    /// <summary>
    /// Option to enable Helm Operator for this git configuration.
    /// </summary>
    public BicepValue<bool> IsHelmOperatorEnabled 
    {
        get { Initialize(); return _isHelmOperatorEnabled!; }
        set { Initialize(); _isHelmOperatorEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isHelmOperatorEnabled;

    /// <summary>
    /// Instance name of the operator - identifying the specific configuration.
    /// </summary>
    public BicepValue<string> OperatorInstanceName 
    {
        get { Initialize(); return _operatorInstanceName!; }
        set { Initialize(); _operatorInstanceName!.Assign(value); }
    }
    private BicepValue<string>? _operatorInstanceName;

    /// <summary>
    /// The namespace to which this operator is installed to. Maximum of 253
    /// lower case alphanumeric characters, hyphen and period only.
    /// </summary>
    public BicepValue<string> OperatorNamespace 
    {
        get { Initialize(); return _operatorNamespace!; }
        set { Initialize(); _operatorNamespace!.Assign(value); }
    }
    private BicepValue<string>? _operatorNamespace;

    /// <summary>
    /// Any Parameters for the Operator instance in string format.
    /// </summary>
    public BicepValue<string> OperatorParams 
    {
        get { Initialize(); return _operatorParams!; }
        set { Initialize(); _operatorParams!.Assign(value); }
    }
    private BicepValue<string>? _operatorParams;

    /// <summary>
    /// Scope at which the operator will be installed.
    /// </summary>
    public BicepValue<KubernetesOperatorScope> OperatorScope 
    {
        get { Initialize(); return _operatorScope!; }
        set { Initialize(); _operatorScope!.Assign(value); }
    }
    private BicepValue<KubernetesOperatorScope>? _operatorScope;

    /// <summary>
    /// Type of the operator.
    /// </summary>
    public BicepValue<KubernetesOperator> OperatorType 
    {
        get { Initialize(); return _operatorType!; }
        set { Initialize(); _operatorType!.Assign(value); }
    }
    private BicepValue<KubernetesOperator>? _operatorType;

    /// <summary>
    /// Url of the SourceControl Repository.
    /// </summary>
    public BicepValue<Uri> RepositoryUri 
    {
        get { Initialize(); return _repositoryUri!; }
        set { Initialize(); _repositoryUri!.Assign(value); }
    }
    private BicepValue<Uri>? _repositoryUri;

    /// <summary>
    /// Base64-encoded known_hosts contents containing public SSH keys required
    /// to access private Git instances.
    /// </summary>
    public BicepValue<string> SshKnownHostsContents 
    {
        get { Initialize(); return _sshKnownHostsContents!; }
        set { Initialize(); _sshKnownHostsContents!.Assign(value); }
    }
    private BicepValue<string>? _sshKnownHostsContents;

    /// <summary>
    /// Compliance Status of the Configuration.
    /// </summary>
    public KubernetesConfigurationComplianceStatus ComplianceStatus 
    {
        get { Initialize(); return _complianceStatus!; }
    }
    private KubernetesConfigurationComplianceStatus? _complianceStatus;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The provisioning state of the resource provider.
    /// </summary>
    public BicepValue<KubernetesConfigurationProvisioningStateType> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<KubernetesConfigurationProvisioningStateType>? _provisioningState;

    /// <summary>
    /// Public Key associated with this SourceControl configuration (either
    /// generated within the cluster or provided by the user).
    /// </summary>
    public BicepValue<string> RepositoryPublicKey 
    {
        get { Initialize(); return _repositoryPublicKey!; }
    }
    private BicepValue<string>? _repositoryPublicKey;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new KubernetesSourceControlConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// KubernetesSourceControlConfiguration resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KubernetesSourceControlConfiguration.</param>
    public KubernetesSourceControlConfiguration(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.KubernetesConfiguration/sourceControlConfigurations", resourceVersion ?? "2023-05-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// KubernetesSourceControlConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _configurationProtectedSettings = DefineDictionaryProperty<string>("ConfigurationProtectedSettings", ["properties", "configurationProtectedSettings"]);
        _helmOperatorProperties = DefineModelProperty<HelmOperatorProperties>("HelmOperatorProperties", ["properties", "helmOperatorProperties"]);
        _isHelmOperatorEnabled = DefineProperty<bool>("IsHelmOperatorEnabled", ["properties", "enableHelmOperator"]);
        _operatorInstanceName = DefineProperty<string>("OperatorInstanceName", ["properties", "operatorInstanceName"]);
        _operatorNamespace = DefineProperty<string>("OperatorNamespace", ["properties", "operatorNamespace"]);
        _operatorParams = DefineProperty<string>("OperatorParams", ["properties", "operatorParams"]);
        _operatorScope = DefineProperty<KubernetesOperatorScope>("OperatorScope", ["properties", "operatorScope"]);
        _operatorType = DefineProperty<KubernetesOperator>("OperatorType", ["properties", "operatorType"]);
        _repositoryUri = DefineProperty<Uri>("RepositoryUri", ["properties", "repositoryUrl"]);
        _sshKnownHostsContents = DefineProperty<string>("SshKnownHostsContents", ["properties", "sshKnownHostsContents"]);
        _complianceStatus = DefineModelProperty<KubernetesConfigurationComplianceStatus>("ComplianceStatus", ["properties", "complianceStatus"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<KubernetesConfigurationProvisioningStateType>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _repositoryPublicKey = DefineProperty<string>("RepositoryPublicKey", ["properties", "repositoryPublicKey"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported KubernetesSourceControlConfiguration resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing KubernetesSourceControlConfiguration.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// KubernetesSourceControlConfiguration resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the KubernetesSourceControlConfiguration.</param>
    /// <returns>The existing KubernetesSourceControlConfiguration resource.</returns>
    public static KubernetesSourceControlConfiguration FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
