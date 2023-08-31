// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Availability group configuration. </summary>
    internal partial class AvailabilityGroupConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupConfiguration"/>. </summary>
        public AvailabilityGroupConfiguration()
        {
            Replicas = new ChangeTrackingList<AvailabilityGroupReplica>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailabilityGroupConfiguration"/>. </summary>
        /// <param name="replicas"> Replica configurations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailabilityGroupConfiguration(IList<AvailabilityGroupReplica> replicas, Dictionary<string, BinaryData> rawData)
        {
            Replicas = replicas;
            _rawData = rawData;
        }

        /// <summary> Replica configurations. </summary>
        public IList<AvailabilityGroupReplica> Replicas { get; }
    }
}
