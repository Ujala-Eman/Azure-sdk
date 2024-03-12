// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the PostArgs condition for the delivery rule. </summary>
    public partial class DeliveryRulePostArgsCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRulePostArgsCondition"/>. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRulePostArgsCondition(PostArgsMatchCondition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = MatchVariable.PostArgs;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRulePostArgsCondition"/>. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        internal DeliveryRulePostArgsCondition(MatchVariable name, IDictionary<string, BinaryData> serializedAdditionalRawData, PostArgsMatchCondition properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRulePostArgsCondition"/> for deserialization. </summary>
        internal DeliveryRulePostArgsCondition()
        {
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public PostArgsMatchCondition Properties { get; set; }
    }
}
