// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityAndCompliance.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Export operation configuration information
    /// </summary>
    public partial class ServiceExportConfigurationInfo
    {
        /// <summary>
        /// Initializes a new instance of the ServiceExportConfigurationInfo
        /// class.
        /// </summary>
        public ServiceExportConfigurationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceExportConfigurationInfo
        /// class.
        /// </summary>
        /// <param name="storageAccountName">The name of the default export
        /// storage account.</param>
        public ServiceExportConfigurationInfo(string storageAccountName = default(string))
        {
            StorageAccountName = storageAccountName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the default export storage account.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountName")]
        public string StorageAccountName { get; set; }

    }
}
