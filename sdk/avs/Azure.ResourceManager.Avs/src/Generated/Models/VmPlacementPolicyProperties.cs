// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> VM-VM placement policy properties. </summary>
    public partial class VmPlacementPolicyProperties : PlacementPolicyProperties
    {
        /// <summary> Initializes a new instance of <see cref="VmPlacementPolicyProperties"/>. </summary>
        /// <param name="vmMembers"> Virtual machine members list. </param>
        /// <param name="affinityType"> placement policy affinity type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmMembers"/> is null. </exception>
        public VmPlacementPolicyProperties(IEnumerable<string> vmMembers, AffinityType affinityType)
        {
            Argument.AssertNotNull(vmMembers, nameof(vmMembers));

            VmMembers = vmMembers.ToList();
            AffinityType = affinityType;
            Type = PlacementPolicyType.VmVm;
        }

        /// <summary> Initializes a new instance of <see cref="VmPlacementPolicyProperties"/>. </summary>
        /// <param name="type"> Placement Policy type. </param>
        /// <param name="state"> Whether the placement policy is enabled or disabled. </param>
        /// <param name="displayName"> Display name of the placement policy. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="vmMembers"> Virtual machine members list. </param>
        /// <param name="affinityType"> placement policy affinity type. </param>
        internal VmPlacementPolicyProperties(PlacementPolicyType type, PlacementPolicyState? state, string displayName, PlacementPolicyProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> vmMembers, AffinityType affinityType) : base(type, state, displayName, provisioningState, serializedAdditionalRawData)
        {
            VmMembers = vmMembers;
            AffinityType = affinityType;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="VmPlacementPolicyProperties"/> for deserialization. </summary>
        internal VmPlacementPolicyProperties()
        {
        }

        /// <summary> Virtual machine members list. </summary>
        public IList<string> VmMembers { get; }
        /// <summary> placement policy affinity type. </summary>
        public AffinityType AffinityType { get; set; }
    }
}
