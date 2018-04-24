// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Non-compliance summary on a particular summary level.
    /// </summary>
    public partial class SummaryResults
    {
        /// <summary>
        /// Initializes a new instance of the SummaryResults class.
        /// </summary>
        public SummaryResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SummaryResults class.
        /// </summary>
        /// <param name="queryResultsUri">HTTP POST URI for queryResults action
        /// on Microsoft.PolicyInsights to retrieve raw results for the
        /// non-compliance summary.</param>
        /// <param name="nonCompliantResources">Number of non-compliant
        /// resources.</param>
        /// <param name="nonCompliantPolicies">Number of non-compliant
        /// policies.</param>
        public SummaryResults(string queryResultsUri = default(string), int? nonCompliantResources = default(int?), int? nonCompliantPolicies = default(int?))
        {
            QueryResultsUri = queryResultsUri;
            NonCompliantResources = nonCompliantResources;
            NonCompliantPolicies = nonCompliantPolicies;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets HTTP POST URI for queryResults action on
        /// Microsoft.PolicyInsights to retrieve raw results for the
        /// non-compliance summary.
        /// </summary>
        [JsonProperty(PropertyName = "queryResultsUri")]
        public string QueryResultsUri { get; set; }

        /// <summary>
        /// Gets or sets number of non-compliant resources.
        /// </summary>
        [JsonProperty(PropertyName = "nonCompliantResources")]
        public int? NonCompliantResources { get; set; }

        /// <summary>
        /// Gets or sets number of non-compliant policies.
        /// </summary>
        [JsonProperty(PropertyName = "nonCompliantPolicies")]
        public int? NonCompliantPolicies { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NonCompliantResources < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "NonCompliantResources", 0);
            }
            if (NonCompliantPolicies < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "NonCompliantPolicies", 0);
            }
        }
    }
}
