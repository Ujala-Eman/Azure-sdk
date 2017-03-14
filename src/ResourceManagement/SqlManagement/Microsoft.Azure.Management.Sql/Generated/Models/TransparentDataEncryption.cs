// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a database transparent data encryption .
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TransparentDataEncryption : SqlSubResource
    {
        /// <summary>
        /// Initializes a new instance of the TransparentDataEncryption class.
        /// </summary>
        public TransparentDataEncryption()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransparentDataEncryption class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="status">The status of the database transparent data
        /// encryption. Possible values include: 'Enabled', 'Disabled'</param>
        public TransparentDataEncryption(string name = default(string), string id = default(string), TransparentDataEncryptionStates? status = default(TransparentDataEncryptionStates?))
            : base(name, id)
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of the database transparent data
        /// encryption. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public TransparentDataEncryptionStates? Status { get; set; }

    }
}
