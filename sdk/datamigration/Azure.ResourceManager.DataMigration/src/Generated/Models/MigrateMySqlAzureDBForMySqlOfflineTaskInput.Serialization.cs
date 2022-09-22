// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateMySqlAzureDBForMySqlOfflineTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo");
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WritePropertyName("targetConnectionInfo");
            writer.WriteObjectValue(TargetConnectionInfo);
            writer.WritePropertyName("selectedDatabases");
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(MakeSourceServerReadOnly))
            {
                writer.WritePropertyName("makeSourceServerReadOnly");
                writer.WriteBooleanValue(MakeSourceServerReadOnly.Value);
            }
            if (Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn");
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(OptionalAgentSettings))
            {
                writer.WritePropertyName("optionalAgentSettings");
                writer.WriteStartObject();
                foreach (var item in OptionalAgentSettings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields");
                writer.WriteStringValue(EncryptedKeyForSecureFields);
            }
            writer.WriteEndObject();
        }

        internal static MigrateMySqlAzureDBForMySqlOfflineTaskInput DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskInput(JsonElement element)
        {
            MySqlConnectionInfo sourceConnectionInfo = default;
            MySqlConnectionInfo targetConnectionInfo = default;
            IList<MigrateMySqlAzureDBForMySqlOfflineDatabaseInput> selectedDatabases = default;
            Optional<bool> makeSourceServerReadOnly = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<IDictionary<string, string>> optionalAgentSettings = default;
            Optional<string> encryptedKeyForSecureFields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"))
                {
                    sourceConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"))
                {
                    targetConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("selectedDatabases"))
                {
                    List<MigrateMySqlAzureDBForMySqlOfflineDatabaseInput> array = new List<MigrateMySqlAzureDBForMySqlOfflineDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateMySqlAzureDBForMySqlOfflineDatabaseInput.DeserializeMigrateMySqlAzureDBForMySqlOfflineDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("makeSourceServerReadOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    makeSourceServerReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("startedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("optionalAgentSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    optionalAgentSettings = dictionary;
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateMySqlAzureDBForMySqlOfflineTaskInput(sourceConnectionInfo, targetConnectionInfo, selectedDatabases, Optional.ToNullable(makeSourceServerReadOnly), Optional.ToNullable(startedOn), Optional.ToDictionary(optionalAgentSettings), encryptedKeyForSecureFields.Value);
        }
    }
}
