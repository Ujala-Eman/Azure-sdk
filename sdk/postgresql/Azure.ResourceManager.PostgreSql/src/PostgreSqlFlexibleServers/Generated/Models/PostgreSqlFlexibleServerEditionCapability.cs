// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Flexible server edition capabilities. </summary>
    public partial class PostgreSqlFlexibleServerEditionCapability
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerEditionCapability. </summary>
        internal PostgreSqlFlexibleServerEditionCapability()
        {
            SupportedStorageEditions = new ChangeTrackingList<PostgreSqlFlexibleServerStorageEditionCapability>();
            SupportedServerVersions = new ChangeTrackingList<PostgreSqlFlexibleServerServerVersionCapability>();
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerEditionCapability. </summary>
        /// <param name="name"> Server edition name. </param>
        /// <param name="supportedStorageEditions"> The list of editions supported by this server edition. </param>
        /// <param name="supportedServerVersions"> The list of server versions supported by this server edition. </param>
        /// <param name="status"> The status. </param>
        internal PostgreSqlFlexibleServerEditionCapability(string name, IReadOnlyList<PostgreSqlFlexibleServerStorageEditionCapability> supportedStorageEditions, IReadOnlyList<PostgreSqlFlexibleServerServerVersionCapability> supportedServerVersions, string status)
        {
            Name = name;
            SupportedStorageEditions = supportedStorageEditions;
            SupportedServerVersions = supportedServerVersions;
            Status = status;
        }

        /// <summary> Server edition name. </summary>
        public string Name { get; }
        /// <summary> The list of editions supported by this server edition. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerStorageEditionCapability> SupportedStorageEditions { get; }
        /// <summary> The list of server versions supported by this server edition. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerServerVersionCapability> SupportedServerVersions { get; }
        /// <summary> The status. </summary>
        public string Status { get; }
    }
}
