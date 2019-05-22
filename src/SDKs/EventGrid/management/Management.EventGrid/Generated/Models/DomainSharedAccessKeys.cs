// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Shared access keys of the Domain.
    /// </summary>
    public partial class DomainSharedAccessKeys
    {
        /// <summary>
        /// Initializes a new instance of the DomainSharedAccessKeys class.
        /// </summary>
        public DomainSharedAccessKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomainSharedAccessKeys class.
        /// </summary>
        /// <param name="key1">Shared access key1 for the domain.</param>
        /// <param name="key2">Shared access key2 for the domain.</param>
        public DomainSharedAccessKeys(string key1 = default(string), string key2 = default(string))
        {
            Key1 = key1;
            Key2 = key2;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shared access key1 for the domain.
        /// </summary>
        [JsonProperty(PropertyName = "key1")]
        public string Key1 { get; set; }

        /// <summary>
        /// Gets or sets shared access key2 for the domain.
        /// </summary>
        [JsonProperty(PropertyName = "key2")]
        public string Key2 { get; set; }

    }
}
