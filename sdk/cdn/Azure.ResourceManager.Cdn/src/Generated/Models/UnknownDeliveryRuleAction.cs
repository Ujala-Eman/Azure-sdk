// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The UnknownDeliveryRuleAction. </summary>
    internal partial class UnknownDeliveryRuleAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDeliveryRuleAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDeliveryRuleAction(DeliveryRuleActionType name, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(name, serializedAdditionalRawData)
        {
            Name = name;
        }
    }
}
