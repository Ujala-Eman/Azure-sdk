// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Azure Active Directory identity configuration for a resource. </summary>
    public partial class DatabaseIdentity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseIdentity"/>. </summary>
        public DatabaseIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseIdentity"/>. </summary>
        /// <param name="identityType"> The identity type. </param>
        /// <param name="tenantId"> The Azure Active Directory tenant id. </param>
        /// <param name="userAssignedIdentities"> The resource ids of the user assigned identities to use. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseIdentity(DatabaseIdentityType? identityType, Guid? tenantId, IDictionary<string, UserAssignedIdentity> userAssignedIdentities, Dictionary<string, BinaryData> rawData)
        {
            IdentityType = identityType;
            TenantId = tenantId;
            UserAssignedIdentities = userAssignedIdentities;
            _rawData = rawData;
        }

        /// <summary> The identity type. </summary>
        public DatabaseIdentityType? IdentityType { get; set; }
        /// <summary> The Azure Active Directory tenant id. </summary>
        public Guid? TenantId { get; }
        /// <summary> The resource ids of the user assigned identities to use. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
