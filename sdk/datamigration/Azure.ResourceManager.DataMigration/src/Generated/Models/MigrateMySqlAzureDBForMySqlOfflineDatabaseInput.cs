// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database specific information for offline MySQL to Azure Database for MySQL migration task inputs. </summary>
    public partial class MigrateMySqlAzureDBForMySqlOfflineDatabaseInput
    {
        /// <summary> Initializes a new instance of MigrateMySqlAzureDBForMySqlOfflineDatabaseInput. </summary>
        public MigrateMySqlAzureDBForMySqlOfflineDatabaseInput()
        {
            TableMap = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of MigrateMySqlAzureDBForMySqlOfflineDatabaseInput. </summary>
        /// <param name="name"> Name of the database. </param>
        /// <param name="targetDatabaseName"> Name of target database. Note: Target database will be truncated before starting migration. </param>
        /// <param name="tableMap"> Mapping of source to target tables. </param>
        internal MigrateMySqlAzureDBForMySqlOfflineDatabaseInput(string name, string targetDatabaseName, IDictionary<string, string> tableMap)
        {
            Name = name;
            TargetDatabaseName = targetDatabaseName;
            TableMap = tableMap;
        }

        /// <summary> Name of the database. </summary>
        public string Name { get; set; }
        /// <summary> Name of target database. Note: Target database will be truncated before starting migration. </summary>
        public string TargetDatabaseName { get; set; }
        /// <summary> Mapping of source to target tables. </summary>
        public IDictionary<string, string> TableMap { get; }
    }
}
