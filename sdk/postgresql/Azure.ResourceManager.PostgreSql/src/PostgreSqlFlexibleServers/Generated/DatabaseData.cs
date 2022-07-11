// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary> A class representing the Database data model. </summary>
    public partial class DatabaseData : ResourceData
    {
        /// <summary> Initializes a new instance of DatabaseData. </summary>
        public DatabaseData()
        {
        }

        /// <summary> Initializes a new instance of DatabaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="charset"> The charset of the database. </param>
        /// <param name="collation"> The collation of the database. </param>
        internal DatabaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string charset, string collation) : base(id, name, resourceType, systemData)
        {
            Charset = charset;
            Collation = collation;
        }

        /// <summary> The charset of the database. </summary>
        public string Charset { get; set; }
        /// <summary> The collation of the database. </summary>
        public string Collation { get; set; }
    }
}
