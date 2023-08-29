// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary>
    /// Properties of the Application Group policy
    /// Please note <see cref="EventHubsApplicationGroupPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="EventHubsThrottlingPolicy"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownEventHubsApplicationGroupPolicy))]
    public abstract partial class EventHubsApplicationGroupPolicy
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventHubsApplicationGroupPolicy"/>. </summary>
        /// <param name="name"> The Name of this policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        protected EventHubsApplicationGroupPolicy(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsApplicationGroupPolicy"/>. </summary>
        /// <param name="name"> The Name of this policy. </param>
        /// <param name="applicationGroupPolicyType"> Application Group Policy types. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsApplicationGroupPolicy(string name, ApplicationGroupPolicyType applicationGroupPolicyType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ApplicationGroupPolicyType = applicationGroupPolicyType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsApplicationGroupPolicy"/> for deserialization. </summary>
        internal EventHubsApplicationGroupPolicy()
        {
        }

        /// <summary> The Name of this policy. </summary>
        public string Name { get; set; }
        /// <summary> Application Group Policy types. </summary>
        internal ApplicationGroupPolicyType ApplicationGroupPolicyType { get; set; }
    }
}
