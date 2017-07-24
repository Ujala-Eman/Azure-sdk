// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Configure pairing input.
    /// </summary>
    public partial class CreateProtectionContainerMappingInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateProtectionContainerMappingInput class.
        /// </summary>
        public CreateProtectionContainerMappingInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateProtectionContainerMappingInput class.
        /// </summary>
        /// <param name="properties">Configure protection input
        /// properties.</param>
        public CreateProtectionContainerMappingInput(CreateProtectionContainerMappingInputProperties properties = default(CreateProtectionContainerMappingInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets configure protection input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CreateProtectionContainerMappingInputProperties Properties { get; set; }

    }
}
