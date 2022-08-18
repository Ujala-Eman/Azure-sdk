// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Policy definition group summary. </summary>
    public partial class PolicyGroupSummary
    {
        /// <summary> Initializes a new instance of PolicyGroupSummary. </summary>
        internal PolicyGroupSummary()
        {
        }

        /// <summary> Initializes a new instance of PolicyGroupSummary. </summary>
        /// <param name="policyGroupName"> Policy group name. </param>
        /// <param name="results"> Compliance summary for the policy definition group. </param>
        internal PolicyGroupSummary(string policyGroupName, SummaryResults results)
        {
            PolicyGroupName = policyGroupName;
            Results = results;
        }

        /// <summary> Policy group name. </summary>
        public string PolicyGroupName { get; }
        /// <summary> Compliance summary for the policy definition group. </summary>
        public SummaryResults Results { get; }
    }
}
