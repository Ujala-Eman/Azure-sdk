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
    /// E2A  Network Mapping fabric specific settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("VmmToAzure")]
    public partial class VmmToAzureNetworkMappingSettings : NetworkMappingFabricSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the VmmToAzureNetworkMappingSettings
        /// class.
        /// </summary>
        public VmmToAzureNetworkMappingSettings()
        {
          CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
