// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Base class for fabric specific details of container. </summary>
    internal partial class ProtectionContainerFabricSpecificDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProtectionContainerFabricSpecificDetails"/>. </summary>
        internal ProtectionContainerFabricSpecificDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProtectionContainerFabricSpecificDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProtectionContainerFabricSpecificDetails(string instanceType, Dictionary<string, BinaryData> rawData)
        {
            InstanceType = instanceType;
            _rawData = rawData;
        }

        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        public string InstanceType { get; }
    }
}
