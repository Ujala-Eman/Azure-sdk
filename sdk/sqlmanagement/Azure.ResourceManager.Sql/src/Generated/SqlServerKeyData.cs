// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SqlServerKey data model. </summary>
    public partial class SqlServerKeyData : ResourceData
    {
        /// <summary> Initializes a new instance of SqlServerKeyData. </summary>
        public SqlServerKeyData()
        {
        }

        /// <summary> Initializes a new instance of SqlServerKeyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of encryption protector. This is metadata used for the Azure portal experience. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="subregion"> Subregion of the server key. </param>
        /// <param name="serverKeyType"> The server key type like &apos;ServiceManaged&apos;, &apos;AzureKeyVault&apos;. </param>
        /// <param name="uri"> The URI of the server key. If the ServerKeyType is AzureKeyVault, then the URI is required. </param>
        /// <param name="thumbprint"> Thumbprint of the server key. </param>
        /// <param name="createdOn"> The server key creation date. </param>
        /// <param name="autoRotationEnabled"> Key auto rotation opt-in flag. Either true or false. </param>
        internal SqlServerKeyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, AzureLocation? location, string subregion, ServerKeyType? serverKeyType, Uri uri, string thumbprint, DateTimeOffset? createdOn, bool? autoRotationEnabled) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            Location = location;
            Subregion = subregion;
            ServerKeyType = serverKeyType;
            Uri = uri;
            Thumbprint = thumbprint;
            CreatedOn = createdOn;
            AutoRotationEnabled = autoRotationEnabled;
        }

        /// <summary> Kind of encryption protector. This is metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Subregion of the server key. </summary>
        public string Subregion { get; }
        /// <summary> The server key type like &apos;ServiceManaged&apos;, &apos;AzureKeyVault&apos;. </summary>
        public ServerKeyType? ServerKeyType { get; set; }
        /// <summary> The URI of the server key. If the ServerKeyType is AzureKeyVault, then the URI is required. </summary>
        public Uri Uri { get; set; }
        /// <summary> Thumbprint of the server key. </summary>
        public string Thumbprint { get; }
        /// <summary> The server key creation date. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Key auto rotation opt-in flag. Either true or false. </summary>
        public bool? AutoRotationEnabled { get; }
    }
}
