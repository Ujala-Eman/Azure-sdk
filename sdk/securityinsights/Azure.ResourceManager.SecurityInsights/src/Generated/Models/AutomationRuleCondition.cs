// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Describes an automation rule condition.
    /// Please note <see cref="AutomationRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="PropertyConditionProperties"/>, <see cref="PropertyArrayChangedConditionProperties"/> and <see cref="PropertyChangedConditionProperties"/>.
    /// </summary>
    public partial class AutomationRuleCondition
    {
        /// <summary> Initializes a new instance of AutomationRuleCondition. </summary>
        public AutomationRuleCondition()
        {
        }

        /// <summary> Initializes a new instance of AutomationRuleCondition. </summary>
        /// <param name="conditionType"></param>
        internal AutomationRuleCondition(ConditionType conditionType)
        {
            ConditionType = conditionType;
        }

        /// <summary> Gets or sets the condition type. </summary>
        internal ConditionType ConditionType { get; set; }
    }
}
