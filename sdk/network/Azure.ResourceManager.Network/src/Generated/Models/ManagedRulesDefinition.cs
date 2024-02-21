// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Allow to exclude some variable satisfy the condition for the WAF check. </summary>
    public partial class ManagedRulesDefinition
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedRulesDefinition"/>. </summary>
        /// <param name="managedRuleSets"> The managed rule sets that are associated with the policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedRuleSets"/> is null. </exception>
        public ManagedRulesDefinition(IEnumerable<ManagedRuleSet> managedRuleSets)
        {
            Argument.AssertNotNull(managedRuleSets, nameof(managedRuleSets));

            Exclusions = new ChangeTrackingList<OwaspCrsExclusionEntry>();
            ManagedRuleSets = managedRuleSets.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRulesDefinition"/>. </summary>
        /// <param name="exclusions"> The Exclusions that are applied on the policy. </param>
        /// <param name="managedRuleSets"> The managed rule sets that are associated with the policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRulesDefinition(IList<OwaspCrsExclusionEntry> exclusions, IList<ManagedRuleSet> managedRuleSets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Exclusions = exclusions;
            ManagedRuleSets = managedRuleSets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRulesDefinition"/> for deserialization. </summary>
        internal ManagedRulesDefinition()
        {
        }

        /// <summary> The Exclusions that are applied on the policy. </summary>
        public IList<OwaspCrsExclusionEntry> Exclusions { get; }
        /// <summary> The managed rule sets that are associated with the policy. </summary>
        public IList<ManagedRuleSet> ManagedRuleSets { get; }
    }
}
