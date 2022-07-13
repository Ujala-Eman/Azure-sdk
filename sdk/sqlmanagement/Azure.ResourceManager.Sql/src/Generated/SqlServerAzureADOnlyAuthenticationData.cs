// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SqlServerAzureADOnlyAuthentication data model. </summary>
    public partial class SqlServerAzureADOnlyAuthenticationData : ResourceData
    {
        /// <summary> Initializes a new instance of SqlServerAzureADOnlyAuthenticationData. </summary>
        public SqlServerAzureADOnlyAuthenticationData()
        {
        }

        /// <summary> Initializes a new instance of SqlServerAzureADOnlyAuthenticationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="azureADOnlyAuthentication"> Azure Active Directory only Authentication enabled. </param>
        internal SqlServerAzureADOnlyAuthenticationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? azureADOnlyAuthentication) : base(id, name, resourceType, systemData)
        {
            AzureADOnlyAuthentication = azureADOnlyAuthentication;
        }

        /// <summary> Azure Active Directory only Authentication enabled. </summary>
        public bool? AzureADOnlyAuthentication { get; set; }
    }
}
