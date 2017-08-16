// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameter supplied to the Apply Network configuration operation.
    /// </summary>
    public partial class ApiManagementServiceApplyNetworkConfigurationParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceApplyNetworkConfigurationParameters class.
        /// </summary>
        public ApiManagementServiceApplyNetworkConfigurationParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceApplyNetworkConfigurationParameters class.
        /// </summary>
        /// <param name="location">Location of the Api Management service to
        /// update for a multi-region service. For a service deployed in a
        /// single region, this parameter is not required.</param>
        public ApiManagementServiceApplyNetworkConfigurationParameters(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets location of the Api Management service to update for a
        /// multi-region service. For a service deployed in a single region,
        /// this parameter is not required.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}
