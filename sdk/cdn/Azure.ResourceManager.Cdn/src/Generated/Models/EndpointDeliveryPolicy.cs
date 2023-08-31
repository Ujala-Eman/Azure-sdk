// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> A policy that specifies the delivery rules to be used for an endpoint. </summary>
    public partial class EndpointDeliveryPolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EndpointDeliveryPolicy"/>. </summary>
        /// <param name="rules"> A list of the delivery rules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rules"/> is null. </exception>
        public EndpointDeliveryPolicy(IEnumerable<DeliveryRule> rules)
        {
            Argument.AssertNotNull(rules, nameof(rules));

            Rules = rules.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="EndpointDeliveryPolicy"/>. </summary>
        /// <param name="description"> User-friendly description of the policy. </param>
        /// <param name="rules"> A list of the delivery rules. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointDeliveryPolicy(string description, IList<DeliveryRule> rules, Dictionary<string, BinaryData> rawData)
        {
            Description = description;
            Rules = rules;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EndpointDeliveryPolicy"/> for deserialization. </summary>
        internal EndpointDeliveryPolicy()
        {
        }

        /// <summary> User-friendly description of the policy. </summary>
        public string Description { get; set; }
        /// <summary> A list of the delivery rules. </summary>
        public IList<DeliveryRule> Rules { get; }
    }
}
