// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBSyncTaskOutput
    {
        internal static MigrateSqlServerSqlDBSyncTaskOutput DeserializeMigrateSqlServerSqlDBSyncTaskOutput(JsonElement element)
        {
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelErrorOutput": return MigrateSqlServerSqlDBSyncTaskOutputDatabaseError.DeserializeMigrateSqlServerSqlDBSyncTaskOutputDatabaseError(element);
                    case "DatabaseLevelOutput": return MigrateSqlServerSqlDBSyncTaskOutputDatabaseLevel.DeserializeMigrateSqlServerSqlDBSyncTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateSqlServerSqlDBSyncTaskOutputError.DeserializeMigrateSqlServerSqlDBSyncTaskOutputError(element);
                    case "MigrationLevelOutput": return MigrateSqlServerSqlDBSyncTaskOutputMigrationLevel.DeserializeMigrateSqlServerSqlDBSyncTaskOutputMigrationLevel(element);
                    case "TableLevelOutput": return MigrateSqlServerSqlDBSyncTaskOutputTableLevel.DeserializeMigrateSqlServerSqlDBSyncTaskOutputTableLevel(element);
                }
            }
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownMigrateSqlServerSqlDBSyncTaskOutput(id.Value, resultType);
        }
    }
}
