// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Extended Properties for Azure IaasVM Backup.
    /// </summary>
    public partial class ExtendedProperties
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedProperties class.
        /// </summary>
        public ExtendedProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedProperties class.
        /// </summary>
        /// <param name="diskExclusionProperties">Extended Properties for Disk
        /// Exclusion.</param>
        public ExtendedProperties(DiskExclusionProperties diskExclusionProperties = default(DiskExclusionProperties))
        {
            DiskExclusionProperties = diskExclusionProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets extended Properties for Disk Exclusion.
        /// </summary>
        [JsonProperty(PropertyName = "diskExclusionProperties")]
        public DiskExclusionProperties DiskExclusionProperties { get; set; }

    }
}
