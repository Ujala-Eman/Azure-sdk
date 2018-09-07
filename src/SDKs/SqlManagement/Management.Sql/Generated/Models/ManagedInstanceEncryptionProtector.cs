// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The managed instance encryption protector.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedInstanceEncryptionProtector : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedInstanceEncryptionProtector class.
        /// </summary>
        public ManagedInstanceEncryptionProtector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedInstanceEncryptionProtector class.
        /// </summary>
        /// <param name="serverKeyType">The encryption protector type like
        /// 'ServiceManaged', 'AzureKeyVault'. Possible values include:
        /// 'ServiceManaged', 'AzureKeyVault'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="kind">Kind of encryption protector. This is metadata
        /// used for the Azure portal experience.</param>
        /// <param name="serverKeyName">The name of the managed instance
        /// key.</param>
        /// <param name="uri">The URI of the server key.</param>
        /// <param name="thumbprint">Thumbprint of the server key.</param>
        public ManagedInstanceEncryptionProtector(string serverKeyType, string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string serverKeyName = default(string), string uri = default(string), string thumbprint = default(string))
            : base(id, name, type)
        {
            Kind = kind;
            ServerKeyName = serverKeyName;
            ServerKeyType = serverKeyType;
            Uri = uri;
            Thumbprint = thumbprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets kind of encryption protector. This is metadata used for the
        /// Azure portal experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets or sets the name of the managed instance key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverKeyName")]
        public string ServerKeyName { get; set; }

        /// <summary>
        /// Gets or sets the encryption protector type like 'ServiceManaged',
        /// 'AzureKeyVault'. Possible values include: 'ServiceManaged',
        /// 'AzureKeyVault'
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverKeyType")]
        public string ServerKeyType { get; set; }

        /// <summary>
        /// Gets the URI of the server key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uri")]
        public string Uri { get; private set; }

        /// <summary>
        /// Gets thumbprint of the server key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServerKeyType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServerKeyType");
            }
        }
    }
}
