// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database specific information for Oracle to Azure Database for PostgreSQL migration task inputs. </summary>
    public partial class MigrateOracleAzureDBPostgreSqlSyncDatabaseInput
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MigrateOracleAzureDBPostgreSqlSyncDatabaseInput"/>. </summary>
        public MigrateOracleAzureDBPostgreSqlSyncDatabaseInput()
        {
            TableMap = new ChangeTrackingDictionary<string, string>();
            MigrationSetting = new ChangeTrackingDictionary<string, string>();
            SourceSetting = new ChangeTrackingDictionary<string, string>();
            TargetSetting = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrateOracleAzureDBPostgreSqlSyncDatabaseInput"/>. </summary>
        /// <param name="caseManipulation"> How to handle object name casing: either Preserve or ToLower. </param>
        /// <param name="name"> Name of the migration pipeline. </param>
        /// <param name="schemaName"> Name of the source schema. </param>
        /// <param name="tableMap"> Mapping of source to target tables. </param>
        /// <param name="targetDatabaseName"> Name of target database. Note: Target database will be truncated before starting migration. </param>
        /// <param name="migrationSetting"> Migration settings which tune the migration behavior. </param>
        /// <param name="sourceSetting"> Source settings to tune source endpoint migration behavior. </param>
        /// <param name="targetSetting"> Target settings to tune target endpoint migration behavior. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateOracleAzureDBPostgreSqlSyncDatabaseInput(string caseManipulation, string name, string schemaName, IDictionary<string, string> tableMap, string targetDatabaseName, IDictionary<string, string> migrationSetting, IDictionary<string, string> sourceSetting, IDictionary<string, string> targetSetting, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CaseManipulation = caseManipulation;
            Name = name;
            SchemaName = schemaName;
            TableMap = tableMap;
            TargetDatabaseName = targetDatabaseName;
            MigrationSetting = migrationSetting;
            SourceSetting = sourceSetting;
            TargetSetting = targetSetting;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> How to handle object name casing: either Preserve or ToLower. </summary>
        public string CaseManipulation { get; set; }
        /// <summary> Name of the migration pipeline. </summary>
        public string Name { get; set; }
        /// <summary> Name of the source schema. </summary>
        public string SchemaName { get; set; }
        /// <summary> Mapping of source to target tables. </summary>
        public IDictionary<string, string> TableMap { get; }
        /// <summary> Name of target database. Note: Target database will be truncated before starting migration. </summary>
        public string TargetDatabaseName { get; set; }
        /// <summary> Migration settings which tune the migration behavior. </summary>
        public IDictionary<string, string> MigrationSetting { get; }
        /// <summary> Source settings to tune source endpoint migration behavior. </summary>
        public IDictionary<string, string> SourceSetting { get; }
        /// <summary> Target settings to tune target endpoint migration behavior. </summary>
        public IDictionary<string, string> TargetSetting { get; }
    }
}
