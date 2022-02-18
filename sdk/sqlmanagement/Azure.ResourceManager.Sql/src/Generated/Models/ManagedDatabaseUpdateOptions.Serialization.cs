// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedDatabaseUpdateOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation");
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime");
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Optional.IsDefined(CatalogCollation))
            {
                writer.WritePropertyName("catalogCollation");
                writer.WriteStringValue(CatalogCollation.Value.ToString());
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode");
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(StorageContainerUri))
            {
                writer.WritePropertyName("storageContainerUri");
                writer.WriteStringValue(StorageContainerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SourceDatabaseId))
            {
                writer.WritePropertyName("sourceDatabaseId");
                writer.WriteStringValue(SourceDatabaseId);
            }
            if (Optional.IsDefined(RestorableDroppedDatabaseId))
            {
                writer.WritePropertyName("restorableDroppedDatabaseId");
                writer.WriteStringValue(RestorableDroppedDatabaseId);
            }
            if (Optional.IsDefined(StorageContainerSasToken))
            {
                writer.WritePropertyName("storageContainerSasToken");
                writer.WriteStringValue(StorageContainerSasToken);
            }
            if (Optional.IsDefined(RecoverableDatabaseId))
            {
                writer.WritePropertyName("recoverableDatabaseId");
                writer.WriteStringValue(RecoverableDatabaseId);
            }
            if (Optional.IsDefined(LongTermRetentionBackupResourceId))
            {
                writer.WritePropertyName("longTermRetentionBackupResourceId");
                writer.WriteStringValue(LongTermRetentionBackupResourceId);
            }
            if (Optional.IsDefined(AutoCompleteRestore))
            {
                writer.WritePropertyName("autoCompleteRestore");
                writer.WriteBooleanValue(AutoCompleteRestore.Value);
            }
            if (Optional.IsDefined(LastBackupName))
            {
                writer.WritePropertyName("lastBackupName");
                writer.WriteStringValue(LastBackupName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
