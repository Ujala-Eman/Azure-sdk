// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a managed rule set for Exclusions.
    /// </summary>
    public partial class ExclusionManagedRuleSet
    {
        /// <summary>
        /// Initializes a new instance of the ExclusionManagedRuleSet class.
        /// </summary>
        public ExclusionManagedRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExclusionManagedRuleSet class.
        /// </summary>
        /// <param name="ruleSetType">Defines the rule set type to use.</param>
        /// <param name="ruleSetVersion">Defines the version of the rule set to
        /// use.</param>
        /// <param name="ruleGroups">Defines the rule groups to apply to the
        /// rule set.</param>
        public ExclusionManagedRuleSet(string ruleSetType, string ruleSetVersion, IList<ExclusionManagedRuleGroup> ruleGroups = default(IList<ExclusionManagedRuleGroup>))
        {
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroups = ruleGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the rule set type to use.
        /// </summary>
        [JsonProperty(PropertyName = "ruleSetType")]
        public string RuleSetType { get; set; }

        /// <summary>
        /// Gets or sets defines the version of the rule set to use.
        /// </summary>
        [JsonProperty(PropertyName = "ruleSetVersion")]
        public string RuleSetVersion { get; set; }

        /// <summary>
        /// Gets or sets defines the rule groups to apply to the rule set.
        /// </summary>
        [JsonProperty(PropertyName = "ruleGroups")]
        public IList<ExclusionManagedRuleGroup> RuleGroups { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RuleSetType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleSetType");
            }
            if (RuleSetVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleSetVersion");
            }
            if (RuleGroups != null)
            {
                foreach (var element in RuleGroups)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
