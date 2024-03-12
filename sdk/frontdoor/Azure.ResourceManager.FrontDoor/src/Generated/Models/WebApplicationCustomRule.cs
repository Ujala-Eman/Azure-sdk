// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines contents of a web application rule. </summary>
    public partial class WebApplicationCustomRule
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

        /// <summary> Initializes a new instance of <see cref="WebApplicationCustomRule"/>. </summary>
        /// <param name="priority"> Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value. </param>
        /// <param name="ruleType"> Describes type of rule. </param>
        /// <param name="matchConditions"> List of match conditions. </param>
        /// <param name="action"> Describes what action to be applied when rule matches. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="matchConditions"/> is null. </exception>
        public WebApplicationCustomRule(int priority, WebApplicationRuleType ruleType, IEnumerable<WebApplicationRuleMatchCondition> matchConditions, RuleMatchActionType action)
        {
            Argument.AssertNotNull(matchConditions, nameof(matchConditions));

            Priority = priority;
            RuleType = ruleType;
            MatchConditions = matchConditions.ToList();
            Action = action;
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationCustomRule"/>. </summary>
        /// <param name="name"> Describes the name of the rule. </param>
        /// <param name="priority"> Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value. </param>
        /// <param name="enabledState"> Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified. </param>
        /// <param name="ruleType"> Describes type of rule. </param>
        /// <param name="rateLimitDurationInMinutes"> Time window for resetting the rate limit count. Default is 1 minute. </param>
        /// <param name="rateLimitThreshold"> Number of allowed requests per client within the time window. </param>
        /// <param name="matchConditions"> List of match conditions. </param>
        /// <param name="action"> Describes what action to be applied when rule matches. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebApplicationCustomRule(string name, int priority, CustomRuleEnabledState? enabledState, WebApplicationRuleType ruleType, int? rateLimitDurationInMinutes, int? rateLimitThreshold, IList<WebApplicationRuleMatchCondition> matchConditions, RuleMatchActionType action, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Priority = priority;
            EnabledState = enabledState;
            RuleType = ruleType;
            RateLimitDurationInMinutes = rateLimitDurationInMinutes;
            RateLimitThreshold = rateLimitThreshold;
            MatchConditions = matchConditions;
            Action = action;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationCustomRule"/> for deserialization. </summary>
        internal WebApplicationCustomRule()
        {
        }

        /// <summary> Describes the name of the rule. </summary>
        public string Name { get; set; }
        /// <summary> Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value. </summary>
        public int Priority { get; set; }
        /// <summary> Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified. </summary>
        public CustomRuleEnabledState? EnabledState { get; set; }
        /// <summary> Describes type of rule. </summary>
        public WebApplicationRuleType RuleType { get; set; }
        /// <summary> Time window for resetting the rate limit count. Default is 1 minute. </summary>
        public int? RateLimitDurationInMinutes { get; set; }
        /// <summary> Number of allowed requests per client within the time window. </summary>
        public int? RateLimitThreshold { get; set; }
        /// <summary> List of match conditions. </summary>
        public IList<WebApplicationRuleMatchCondition> MatchConditions { get; }
        /// <summary> Describes what action to be applied when rule matches. </summary>
        public RuleMatchActionType Action { get; set; }
    }
}
