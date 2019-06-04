// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The extended Info of the Data Box Edge/Gateway device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataBoxEdgeDeviceExtendedInfo : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the DataBoxEdgeDeviceExtendedInfo
        /// class.
        /// </summary>
        public DataBoxEdgeDeviceExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataBoxEdgeDeviceExtendedInfo
        /// class.
        /// </summary>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="encryptionKeyThumbprint">The digital signature of
        /// encrypted certificate.</param>
        /// <param name="encryptionKey">The public part of the encryption
        /// certificate. Client uses this to encrypt any secret.</param>
        /// <param name="resourceKey">The Resource ID of the Resource.</param>
        public DataBoxEdgeDeviceExtendedInfo(string id = default(string), string name = default(string), string type = default(string), string encryptionKeyThumbprint = default(string), string encryptionKey = default(string), string resourceKey = default(string))
            : base(id, name, type)
        {
            EncryptionKeyThumbprint = encryptionKeyThumbprint;
            EncryptionKey = encryptionKey;
            ResourceKey = resourceKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the digital signature of encrypted certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionKeyThumbprint")]
        public string EncryptionKeyThumbprint { get; set; }

        /// <summary>
        /// Gets or sets the public part of the encryption certificate. Client
        /// uses this to encrypt any secret.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionKey")]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Gets the Resource ID of the Resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceKey")]
        public string ResourceKey { get; private set; }

    }
}
