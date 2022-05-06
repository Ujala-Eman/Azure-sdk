// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for RequestMethod match conditions. </summary>
    public partial class RequestMethodMatchConditionDefinition
    {
        /// <summary> Initializes a new instance of RequestMethodMatchConditionDefinition. </summary>
        /// <param name="typeDefinition"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        public RequestMethodMatchConditionDefinition(RequestMethodMatchConditionType typeDefinition, RequestMethodOperator @operator)
        {
            TypeDefinition = typeDefinition;
            Operator = @operator;
            Transforms = new ChangeTrackingList<PreTransformCategory>();
            MatchValues = new ChangeTrackingList<RequestMethodMatchConditionParametersMatchValuesItem>();
        }

        /// <summary> Initializes a new instance of RequestMethodMatchConditionDefinition. </summary>
        /// <param name="typeDefinition"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="transforms"> List of transforms. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        internal RequestMethodMatchConditionDefinition(RequestMethodMatchConditionType typeDefinition, RequestMethodOperator @operator, bool? negateCondition, IList<PreTransformCategory> transforms, IList<RequestMethodMatchConditionParametersMatchValuesItem> matchValues)
        {
            TypeDefinition = typeDefinition;
            Operator = @operator;
            NegateCondition = negateCondition;
            Transforms = transforms;
            MatchValues = matchValues;
        }

        /// <summary> Gets or sets the type definition. </summary>
        public RequestMethodMatchConditionType TypeDefinition { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public RequestMethodOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<RequestMethodMatchConditionParametersMatchValuesItem> MatchValues { get; }
    }
}
