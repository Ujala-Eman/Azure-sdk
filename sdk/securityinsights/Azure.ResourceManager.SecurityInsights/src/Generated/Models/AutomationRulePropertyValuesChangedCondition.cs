// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The AutomationRulePropertyValuesChangedCondition. </summary>
    public partial class AutomationRulePropertyValuesChangedCondition
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

        /// <summary> Initializes a new instance of <see cref="AutomationRulePropertyValuesChangedCondition"/>. </summary>
        public AutomationRulePropertyValuesChangedCondition()
        {
            PropertyValues = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationRulePropertyValuesChangedCondition"/>. </summary>
        /// <param name="propertyName"></param>
        /// <param name="changeType"></param>
        /// <param name="operator"></param>
        /// <param name="propertyValues"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationRulePropertyValuesChangedCondition(AutomationRulePropertyChangedConditionSupportedPropertyType? propertyName, AutomationRulePropertyChangedConditionSupportedChangedType? changeType, AutomationRulePropertyConditionSupportedOperator? @operator, IList<string> propertyValues, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PropertyName = propertyName;
            ChangeType = changeType;
            Operator = @operator;
            PropertyValues = propertyValues;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the property name. </summary>
        public AutomationRulePropertyChangedConditionSupportedPropertyType? PropertyName { get; set; }
        /// <summary> Gets or sets the change type. </summary>
        public AutomationRulePropertyChangedConditionSupportedChangedType? ChangeType { get; set; }
        /// <summary> Gets or sets the operator. </summary>
        public AutomationRulePropertyConditionSupportedOperator? Operator { get; set; }
        /// <summary> Gets the property values. </summary>
        public IList<string> PropertyValues { get; }
    }
}
