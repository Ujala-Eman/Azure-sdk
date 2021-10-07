// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DppIdentityDetails
    /// </summary>
    /// <remarks>
    /// Identity details
    /// </remarks>
    public partial class DppIdentityDetails
    {
        /// <summary>
        /// Initializes a new instance of the DppIdentityDetails class.
        /// </summary>
        public DppIdentityDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DppIdentityDetails class.
        /// </summary>
        /// <param name="principalId">The object ID of the service principal
        /// object for the managed identity that is used to grant role-based
        /// access to an Azure resource.</param>
        /// <param name="tenantId">A Globally Unique Identifier (GUID) that
        /// represents the Azure AD tenant where the resource is now a
        /// member.</param>
        /// <param name="type">The identityType which can be either
        /// SystemAssigned or None</param>
        public DppIdentityDetails(string principalId = default(string), string tenantId = default(string), string type = default(string))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the object ID of the service principal object for the managed
        /// identity that is used to grant role-based access to an Azure
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets a Globally Unique Identifier (GUID) that represents the Azure
        /// AD tenant where the resource is now a member.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the identityType which can be either SystemAssigned or
        /// None
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
