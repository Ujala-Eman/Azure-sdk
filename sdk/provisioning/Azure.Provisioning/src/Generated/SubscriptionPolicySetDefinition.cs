// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// SubscriptionPolicySetDefinition.
/// </summary>
public partial class SubscriptionPolicySetDefinition : ProvisionableResource
{
    /// <summary>
    /// The name of the policy set definition to create.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The policy set definition description.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// The display name of the policy set definition.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; set => _displayName.Assign(value); }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// The policy set definition metadata.  Metadata is an open ended object
    /// and is typically a collection of key value pairs.
    /// To assign an object to this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Metadata { get => _metadata; set => _metadata.Assign(value); }
    private readonly BicepValue<BinaryData> _metadata;

    /// <summary>
    /// The policy set definition parameters that can be used in policy
    /// definition references.
    /// </summary>
    public BicepDictionary<ArmPolicyParameter> Parameters { get => _parameters; set => _parameters.Assign(value); }
    private readonly BicepDictionary<ArmPolicyParameter> _parameters;

    /// <summary>
    /// The metadata describing groups of policy definition references within
    /// the policy set definition.
    /// </summary>
    public BicepList<PolicyDefinitionGroup> PolicyDefinitionGroups { get => _policyDefinitionGroups; set => _policyDefinitionGroups.Assign(value); }
    private readonly BicepList<PolicyDefinitionGroup> _policyDefinitionGroups;

    /// <summary>
    /// An array of policy definition references.
    /// </summary>
    public BicepList<PolicyDefinitionReference> PolicyDefinitions { get => _policyDefinitions; set => _policyDefinitions.Assign(value); }
    private readonly BicepList<PolicyDefinitionReference> _policyDefinitions;

    /// <summary>
    /// The type of policy definition. Possible values are NotSpecified,
    /// BuiltIn, Custom, and Static.
    /// </summary>
    public BicepValue<PolicyType> PolicyType { get => _policyType; set => _policyType.Assign(value); }
    private readonly BicepValue<PolicyType> _policyType;

    /// <summary>
    /// Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Azure Resource Manager metadata containing createdBy and modifiedBy
    /// information.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new SubscriptionPolicySetDefinition.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SubscriptionPolicySetDefinition
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SubscriptionPolicySetDefinition.</param>
    public SubscriptionPolicySetDefinition(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Authorization/policySetDefinitions", resourceVersion)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["properties", "description"]);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["properties", "displayName"]);
        _metadata = BicepValue<BinaryData>.DefineProperty(this, "Metadata", ["properties", "metadata"]);
        _parameters = BicepDictionary<ArmPolicyParameter>.DefineProperty(this, "Parameters", ["properties", "parameters"]);
        _policyDefinitionGroups = BicepList<PolicyDefinitionGroup>.DefineProperty(this, "PolicyDefinitionGroups", ["properties", "policyDefinitionGroups"]);
        _policyDefinitions = BicepList<PolicyDefinitionReference>.DefineProperty(this, "PolicyDefinitions", ["properties", "policyDefinitions"]);
        _policyType = BicepValue<PolicyType>.DefineProperty(this, "PolicyType", ["properties", "policyType"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Creates a reference to an existing SubscriptionPolicySetDefinition.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SubscriptionPolicySetDefinition
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SubscriptionPolicySetDefinition.</param>
    /// <returns>The existing SubscriptionPolicySetDefinition resource.</returns>
    public static SubscriptionPolicySetDefinition FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this SubscriptionPolicySetDefinition
    /// resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 128, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period | ResourceNameCharacters.Parentheses);
}
