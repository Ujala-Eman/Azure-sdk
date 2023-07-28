// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> VirtualMachineList represents a list of virtual machines. </summary>
    internal partial class VirtualMachineList
    {
        /// <summary> Initializes a new instance of VirtualMachineList. </summary>
        internal VirtualMachineList()
        {
            Value = new ChangeTrackingList<NetworkCloudVirtualMachineData>();
        }

        /// <summary> Initializes a new instance of VirtualMachineList. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of virtual machines. </param>
        internal VirtualMachineList(string nextLink, IReadOnlyList<NetworkCloudVirtualMachineData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of virtual machines. </summary>
        public IReadOnlyList<NetworkCloudVirtualMachineData> Value { get; }
    }
}
