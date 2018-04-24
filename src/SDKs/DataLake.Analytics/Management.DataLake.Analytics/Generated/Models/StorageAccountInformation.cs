// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure Storage account information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageAccountInformation : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountInformation class.
        /// </summary>
        public StorageAccountInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountInformation class.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="suffix">The optional suffix for the storage
        /// account.</param>
        public StorageAccountInformation(string id = default(string), string name = default(string), string type = default(string), string suffix = default(string))
            : base(id, name, type)
        {
            Suffix = suffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the optional suffix for the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.suffix")]
        public string Suffix { get; private set; }

    }
}
