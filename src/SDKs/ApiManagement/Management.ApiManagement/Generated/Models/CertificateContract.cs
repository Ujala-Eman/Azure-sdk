// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Certificate details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CertificateContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CertificateContract class.
        /// </summary>
        public CertificateContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateContract class.
        /// </summary>
        /// <param name="subject">Subject attribute of the certificate.</param>
        /// <param name="thumbprint">Thumbprint of the certificate.</param>
        /// <param name="expirationDate">Expiration date of the certificate.
        /// The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ`
        /// as specified by the ISO 8601 standard.
        /// </param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        public CertificateContract(string subject, string thumbprint, System.DateTime expirationDate, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            Subject = subject;
            Thumbprint = thumbprint;
            ExpirationDate = expirationDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets subject attribute of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets thumbprint of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets expiration date of the certificate. The date conforms
        /// to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the
        /// ISO 8601 standard.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationDate")]
        public System.DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Subject == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Subject");
            }
            if (Thumbprint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Thumbprint");
            }
        }
    }
}
