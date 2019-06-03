// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureStack.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// OS disk image.
    /// </summary>
    public partial class OsDiskImage
    {
        /// <summary>
        /// Initializes a new instance of the OsDiskImage class.
        /// </summary>
        public OsDiskImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OsDiskImage class.
        /// </summary>
        /// <param name="operatingSystem">OS operating system type. Possible
        /// values include: 'None', 'Windows', 'Linux'</param>
        /// <param name="sourceBlobSasUri">SAS key for source blob.</param>
        public OsDiskImage(string operatingSystem = default(string), string sourceBlobSasUri = default(string))
        {
            OperatingSystem = operatingSystem;
            SourceBlobSasUri = sourceBlobSasUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets OS operating system type. Possible values include: 'None',
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "operatingSystem")]
        public string OperatingSystem { get; private set; }

        /// <summary>
        /// Gets SAS key for source blob.
        /// </summary>
        [JsonProperty(PropertyName = "sourceBlobSasUri")]
        public string SourceBlobSasUri { get; private set; }

    }
}
