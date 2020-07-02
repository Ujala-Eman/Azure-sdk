// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> The information about security rules applied to the specified VM. </summary>
    public partial class SecurityGroupViewResult
    {
        /// <summary> Initializes a new instance of SecurityGroupViewResult. </summary>
        internal SecurityGroupViewResult()
        {
            NetworkInterfaces = new ChangeTrackingList<SecurityGroupNetworkInterface>();
        }

        /// <summary> Initializes a new instance of SecurityGroupViewResult. </summary>
        /// <param name="networkInterfaces"> List of network interfaces on the specified VM. </param>
        internal SecurityGroupViewResult(IReadOnlyList<SecurityGroupNetworkInterface> networkInterfaces)
        {
            NetworkInterfaces = networkInterfaces;
        }

        /// <summary> List of network interfaces on the specified VM. </summary>
        public IReadOnlyList<SecurityGroupNetworkInterface> NetworkInterfaces { get; }
    }
}
