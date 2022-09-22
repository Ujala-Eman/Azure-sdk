// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Update operation.
    /// </summary>
    public partial class IotHubResourceUpdateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the IotHubResourceUpdateHeaders
        /// class.
        /// </summary>
        public IotHubResourceUpdateHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotHubResourceUpdateHeaders
        /// class.
        /// </summary>
        /// <param name="azureAsyncOperation">URL to query for status of the
        /// operation.</param>
        public IotHubResourceUpdateHeaders(string azureAsyncOperation = default(string))
        {
            AzureAsyncOperation = azureAsyncOperation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL to query for status of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "Azure-AsyncOperation")]
        public string AzureAsyncOperation { get; set; }

    }
}
