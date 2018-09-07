// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An identity that have access to the key vault. All identities in the
    /// array must use the same tenant ID as the key vault's tenant ID.
    /// </summary>
    public partial class AccessPolicyEntry
    {
        /// <summary>
        /// Initializes a new instance of the AccessPolicyEntry class.
        /// </summary>
        public AccessPolicyEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessPolicyEntry class.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory tenant ID that
        /// should be used for authenticating requests to the key
        /// vault.</param>
        /// <param name="objectId">The object ID of a user, service principal
        /// or security group in the Azure Active Directory tenant for the
        /// vault. The object ID must be unique for the list of access
        /// policies.</param>
        /// <param name="permissions">Permissions the identity has for keys,
        /// secrets and certificates.</param>
        /// <param name="applicationId"> Application ID of the client making
        /// request on behalf of a principal</param>
        public AccessPolicyEntry(System.Guid tenantId, string objectId, Permissions permissions, System.Guid? applicationId = default(System.Guid?))
        {
            TenantId = tenantId;
            ObjectId = objectId;
            ApplicationId = applicationId;
            Permissions = permissions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory tenant ID that should be
        /// used for authenticating requests to the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets the object ID of a user, service principal or security
        /// group in the Azure Active Directory tenant for the vault. The
        /// object ID must be unique for the list of access policies.
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or sets  Application ID of the client making request on behalf
        /// of a principal
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public System.Guid? ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets permissions the identity has for keys, secrets and
        /// certificates.
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public Permissions Permissions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ObjectId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ObjectId");
            }
            if (Permissions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Permissions");
            }
        }
    }
}
