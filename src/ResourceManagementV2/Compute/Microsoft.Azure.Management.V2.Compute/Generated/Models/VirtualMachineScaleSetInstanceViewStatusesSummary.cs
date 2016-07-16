// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Instance view statuses summary for virtual machines of a virtual
    /// machine scale set.
    /// </summary>
    public partial class VirtualMachineScaleSetInstanceViewStatusesSummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetInstanceViewStatusesSummary class.
        /// </summary>
        public VirtualMachineScaleSetInstanceViewStatusesSummary() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetInstanceViewStatusesSummary class.
        /// </summary>
        /// <param name="statusesSummary">the extensions information.</param>
        public VirtualMachineScaleSetInstanceViewStatusesSummary(IList<VirtualMachineStatusCodeCount> statusesSummary = default(IList<VirtualMachineStatusCodeCount>))
        {
            StatusesSummary = statusesSummary;
        }

        /// <summary>
        /// Gets the extensions information.
        /// </summary>
        [JsonProperty(PropertyName = "statusesSummary")]
        public IList<VirtualMachineStatusCodeCount> StatusesSummary { get; private set; }

    }
}
