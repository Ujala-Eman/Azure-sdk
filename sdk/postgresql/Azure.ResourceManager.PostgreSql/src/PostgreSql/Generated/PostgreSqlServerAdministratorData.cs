// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary> A class representing the PostgreSqlServerAdministrator data model. </summary>
    public partial class PostgreSqlServerAdministratorData : ResourceData
    {
        /// <summary> Initializes a new instance of PostgreSqlServerAdministratorData. </summary>
        public PostgreSqlServerAdministratorData()
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlServerAdministratorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="administratorType"> The type of administrator. </param>
        /// <param name="loginAccountName"> The server administrator login account name. </param>
        /// <param name="secureId"> The server administrator Sid (Secure ID). </param>
        /// <param name="tenantId"> The server Active Directory Administrator tenant id. </param>
        internal PostgreSqlServerAdministratorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PostgreSqlAdministratorType? administratorType, string loginAccountName, Guid? secureId, Guid? tenantId) : base(id, name, resourceType, systemData)
        {
            AdministratorType = administratorType;
            LoginAccountName = loginAccountName;
            SecureId = secureId;
            TenantId = tenantId;
        }

        /// <summary> The type of administrator. </summary>
        public PostgreSqlAdministratorType? AdministratorType { get; set; }
        /// <summary> The server administrator login account name. </summary>
        public string LoginAccountName { get; set; }
        /// <summary> The server administrator Sid (Secure ID). </summary>
        public Guid? SecureId { get; set; }
        /// <summary> The server Active Directory Administrator tenant id. </summary>
        public Guid? TenantId { get; set; }
    }
}
