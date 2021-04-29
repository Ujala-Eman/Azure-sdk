// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ThirdPartyProviderAuthorization
    {
        /// <summary>
        /// Initializes a new instance of the ThirdPartyProviderAuthorization
        /// class.
        /// </summary>
        public ThirdPartyProviderAuthorization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThirdPartyProviderAuthorization
        /// class.
        /// </summary>
        public ThirdPartyProviderAuthorization(IList<LightHouseAuthorization> authorizations = default(IList<LightHouseAuthorization>), string managedByTenantId = default(string))
        {
            Authorizations = authorizations;
            ManagedByTenantId = managedByTenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authorizations")]
        public IList<LightHouseAuthorization> Authorizations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "managedByTenantId")]
        public string ManagedByTenantId { get; set; }

    }
}
