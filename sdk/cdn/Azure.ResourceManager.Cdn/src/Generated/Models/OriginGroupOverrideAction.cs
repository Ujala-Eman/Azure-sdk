// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the origin group override action for the delivery rule. </summary>
    public partial class OriginGroupOverrideAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideAction"/>. </summary>
        /// <param name="properties"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public OriginGroupOverrideAction(OriginGroupOverrideActionProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Name = DeliveryRuleActionType.OriginGroupOverride;
        }

        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="properties"> Defines the parameters for the action. </param>
        internal OriginGroupOverrideAction(DeliveryRuleActionType name, OriginGroupOverrideActionProperties properties) : base(name)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Defines the parameters for the action. </summary>
        public OriginGroupOverrideActionProperties Properties { get; set; }
    }
}
