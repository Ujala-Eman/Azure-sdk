// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerConnectionPolicy data model.
    /// A server connection policy
    /// </summary>
    public partial class SqlServerConnectionPolicyData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SqlServerConnectionPolicyData"/>. </summary>
        public SqlServerConnectionPolicyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerConnectionPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Metadata used for the Azure portal experience. </param>
        /// <param name="connectionType"> The server connection type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerConnectionPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string kind, ServerConnectionType? connectionType, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Kind = kind;
            ConnectionType = connectionType;
            _rawData = rawData;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> The server connection type. </summary>
        public ServerConnectionType? ConnectionType { get; set; }
    }
}
