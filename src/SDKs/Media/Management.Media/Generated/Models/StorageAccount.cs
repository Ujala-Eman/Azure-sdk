// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The storage account details.
    /// </summary>
    public partial class StorageAccount
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        /// <param name="type">The type of the storage account. Possible values
        /// include: 'Primary', 'Secondary'</param>
        /// <param name="id">The ID of the storage account resource. Media
        /// Services relies on tables and queues as well as blobs, so the
        /// primary storage account must be a Standard Storage account (either
        /// Microsoft.ClassicStorage or Microsoft.Storage). Blob only storage
        /// accounts can be added as secondary storage accounts.</param>
        public StorageAccount(string type, string id = default(string))
        {
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the storage account resource. Media Services
        /// relies on tables and queues as well as blobs, so the primary
        /// storage account must be a Standard Storage account (either
        /// Microsoft.ClassicStorage or Microsoft.Storage). Blob only storage
        /// accounts can be added as secondary storage accounts.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the storage account. Possible values
        /// include: 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
