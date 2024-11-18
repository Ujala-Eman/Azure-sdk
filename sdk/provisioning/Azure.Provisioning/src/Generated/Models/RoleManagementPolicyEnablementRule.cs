// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.Authorization;

/// <summary>
/// The role management policy enablement rule.
/// </summary>
public partial class RoleManagementPolicyEnablementRule : RoleManagementPolicyRule
{
    /// <summary>
    /// The list of enabled rules.
    /// </summary>
    public BicepList<RoleAssignmentEnablementRuleType> EnablementRules 
    {
        get { Initialize(); return _enablementRules!; }
        set { Initialize(); _enablementRules!.Assign(value); }
    }
    private BicepList<RoleAssignmentEnablementRuleType>? _enablementRules;

    /// <summary>
    /// Creates a new RoleManagementPolicyEnablementRule.
    /// </summary>
    public RoleManagementPolicyEnablementRule() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// RoleManagementPolicyEnablementRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("ruleType", ["ruleType"], defaultValue: "RoleManagementPolicyEnablementRule");
        _enablementRules = DefineListProperty<RoleAssignmentEnablementRuleType>("EnablementRules", ["enabledRules"]);
    }
}
