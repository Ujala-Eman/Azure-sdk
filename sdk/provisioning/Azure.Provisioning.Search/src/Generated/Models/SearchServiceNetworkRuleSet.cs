// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Search;

/// <summary>
/// Network specific rules that determine how the Azure AI Search service may
/// be reached.
/// </summary>
public partial class SearchServiceNetworkRuleSet : ProvisionableConstruct
{
    /// <summary>
    /// A list of IP restriction rules that defines the inbound network(s) with
    /// allowing access to the search service endpoint. At the meantime, all
    /// other public IP networks are blocked by the firewall. These
    /// restriction rules are applied only when the
    /// &apos;publicNetworkAccess&apos; of the search service is
    /// &apos;enabled&apos;; otherwise, traffic over public interface is not
    /// allowed even with any public IP rules, and private endpoint
    /// connections would be the exclusive access method.
    /// </summary>
    public BicepList<SearchServiceIPRule> IPRules { get => _iPRules; set => _iPRules.Assign(value); }
    private readonly BicepList<SearchServiceIPRule> _iPRules;

    /// <summary>
    /// Possible origins of inbound traffic that can bypass the rules defined
    /// in the &apos;ipRules&apos; section.
    /// </summary>
    public BicepValue<SearchBypass> Bypass { get => _bypass; set => _bypass.Assign(value); }
    private readonly BicepValue<SearchBypass> _bypass;

    /// <summary>
    /// Creates a new SearchServiceNetworkRuleSet.
    /// </summary>
    public SearchServiceNetworkRuleSet()
    {
        _iPRules = BicepList<SearchServiceIPRule>.DefineProperty(this, "IPRules", ["ipRules"]);
        _bypass = BicepValue<SearchBypass>.DefineProperty(this, "Bypass", ["bypass"]);
    }
}
