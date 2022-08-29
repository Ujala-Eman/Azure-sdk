// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary>
    /// Policy evaluation details.
    /// Serialized Name: PolicyEvaluationDetails
    /// </summary>
    public partial class PolicyEvaluationDetails
    {
        /// <summary> Initializes a new instance of PolicyEvaluationDetails. </summary>
        internal PolicyEvaluationDetails()
        {
            EvaluatedExpressions = new ChangeTrackingList<ExpressionEvaluationDetails>();
        }

        /// <summary> Initializes a new instance of PolicyEvaluationDetails. </summary>
        /// <param name="evaluatedExpressions">
        /// Details of the evaluated expressions.
        /// Serialized Name: PolicyEvaluationDetails.evaluatedExpressions
        /// </param>
        /// <param name="ifNotExistsDetails">
        /// Evaluation details of IfNotExists effect.
        /// Serialized Name: PolicyEvaluationDetails.ifNotExistsDetails
        /// </param>
        internal PolicyEvaluationDetails(IReadOnlyList<ExpressionEvaluationDetails> evaluatedExpressions, IfNotExistsEvaluationDetails ifNotExistsDetails)
        {
            EvaluatedExpressions = evaluatedExpressions;
            IfNotExistsDetails = ifNotExistsDetails;
        }

        /// <summary>
        /// Details of the evaluated expressions.
        /// Serialized Name: PolicyEvaluationDetails.evaluatedExpressions
        /// </summary>
        public IReadOnlyList<ExpressionEvaluationDetails> EvaluatedExpressions { get; }
        /// <summary>
        /// Evaluation details of IfNotExists effect.
        /// Serialized Name: PolicyEvaluationDetails.ifNotExistsDetails
        /// </summary>
        public IfNotExistsEvaluationDetails IfNotExistsDetails { get; }
    }
}
