// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes Windows Remote Management configuration of the VM
    /// </summary>
    public partial class WinRMConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the WinRMConfiguration class.
        /// </summary>
        public WinRMConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WinRMConfiguration class.
        /// </summary>
        /// <param name="listeners">The list of Windows Remote Management
        /// listeners</param>
        public WinRMConfiguration(IList<WinRMListener> listeners = default(IList<WinRMListener>))
        {
            Listeners = listeners;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of Windows Remote Management listeners
        /// </summary>
        [JsonProperty(PropertyName = "listeners")]
        public IList<WinRMListener> Listeners { get; set; }

    }
}
